using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using static System.Net.Mime.MediaTypeNames;
using CapaDatos;
using Npgsql;
using System.Collections;


namespace CapaPresentacion
{

    public partial class frmUtilidades : Form
    {
        public frmUtilidades()
        {
            InitializeComponent();
        }
        private Thread workerThread = null;

        public static string path = @"C:\Sistema ValMar";
        private void frmUtilidades_Load(object sender, EventArgs e)
        {
            textBoxLog.Multiline = true;
        }

        public void actualizaLog(string mensaje)
        {
            if (textBoxLog.InvokeRequired)
            {
                textBoxLog.Invoke(new Action(() =>
                {
                    if (string.IsNullOrEmpty(textBoxLog.Text))
                    {
                        textBoxLog.Text += mensaje;
                    }
                    else
                    {
                        textBoxLog.Text += Environment.NewLine + Environment.NewLine + mensaje;
                    }
                }));
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxLog.Text))
                {
                    textBoxLog.Text += mensaje;
                }
                else
                {
                    textBoxLog.Text += Environment.NewLine + Environment.NewLine + mensaje;
                }
            }

            if (labelActividadActual.InvokeRequired)
            {
                labelActividadActual.Invoke(new Action(() => labelActividadActual.Text = mensaje));
            }
            else
            {
                labelActividadActual.Text = mensaje;
            }
        }

        public void MostrarMensaje(string mensaje, string titulo, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => 
                {
                    MessageBox.Show(this, mensaje, titulo, botones, icono);
                }));
            }
            else
            {
                MessageBox.Show(this, mensaje, titulo, botones, icono);
            }
        }

        public void limpiar()
        {
            if (textBoxNombreTabla.InvokeRequired)
            {
                textBoxNombreTabla.Invoke(new MethodInvoker(limpiar));
                return;
            }
            textBoxNombreTabla.Text = string.Empty;
        }
        public void insertarArchivosBD()
        {
            if (!string.IsNullOrEmpty(textBoxNombreTabla.Text))
            {
                string query = string.Empty;
                DataTable dtInsertarCSV = new DataTable();
                Archivos oArchivos = new Archivos();
                string nombreTabla = textBoxNombreTabla.Text;
                string rutaCarpeta = path + @"\Prueba";
                string rutaArchivo = oArchivos.ObtenerRutaArchivo();

                if (string.IsNullOrEmpty(rutaArchivo))
                {
                    actualizaLog("El usuario canceló la selección del archivo.");
                    MostrarMensaje("No se seleccionó ningún archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                string nombreArchivo = Path.GetFileName(rutaArchivo);

                actualizaLog("Recreando Carpeta: " + rutaCarpeta);
                oArchivos.RecreaCarpeta(rutaCarpeta);

                actualizaLog("Copiando Archivo " + nombreArchivo + " a la carpeta: " + rutaCarpeta);
                oArchivos.CopiarArchivo(nombreArchivo, rutaArchivo, rutaCarpeta);

                actualizaLog("Obteniendo cabecera del archivo");
                string cabecera = oArchivos.ObtieneCabecera(nombreArchivo, rutaCarpeta);
                cabecera = cabecera.Replace(" ", "_").Replace("ñ", "n").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u").Replace("/", "").Replace("__", "_").Replace("-", "").Replace(@"""", "").Replace("ÿ", "").ToLower();
                
                actualizaLog("Obteniendo delimitador del archivo");
                string delimitador = oArchivos.ObtieneDelimitador(rutaCarpeta + @"\" + nombreArchivo, 5).ToString();

                if (!string.IsNullOrEmpty(cabecera) && !string.IsNullOrEmpty(delimitador))
                {
                    cabecera = cabecera.Replace(delimitador, " TEXT, ") + " TEXT";
                    try
                    {
                        actualizaLog("Obteniendo conexión a la base de datos");
                        using (NpgsqlConnection conection = new NpgsqlConnection(Conexion.cadena))
                        {
                            query = $"SELECT out_estado, out_mensaje FROM fun_inserta_csv('{nombreTabla}', '{rutaCarpeta}', '{nombreArchivo}', '{delimitador}', '{cabecera}');";
                            NpgsqlCommand cmd = new NpgsqlCommand(query, conection);
                            cmd.CommandType = System.Data.CommandType.Text;

                            conection.Open();
                            NpgsqlDataReader reader = cmd.ExecuteReader();
                            dtInsertarCSV.Load(reader);

                            if (dtInsertarCSV.Rows[0]["out_estado"].ToString() == "1")
                            {
                                actualizaLog("Finaliza función exitosamente.");
                                MostrarMensaje("Archivo insertado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                oArchivos.EliminarArchivo(nombreArchivo, rutaCarpeta);
                                limpiar();
                                actualizaLog("Finaliza proceso de inserción de archivo CSV.");
                            }
                            else if (dtInsertarCSV.Rows[0]["out_estado"].ToString() == "0")
                            {
                                actualizaLog("Ocurrió un error en función de base de datos.");
                                MostrarMensaje("No se pudo insertar el archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message);
                    }
                }
                else
                {
                    MostrarMensaje("No se pudo obtener la cabecera o el delimitador del archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MostrarMensaje("Favor de escribir el nombre que deseas que tenga la tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            this.workerThread = new Thread(new ThreadStart(this.insertarArchivosBD));
            this.workerThread.SetApartmentState(ApartmentState.STA); // Establecer el estado del apartamento a STA  
            this.workerThread.Start();
        }

        
    }
}