using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Ionic.Zip;
using System.Diagnostics;
using System.Collections;
//using System.Collections.Generic;
//using Aspose.Cells;
//using System.Text;

namespace Utilidades
{
    public class Archivos
    {
        public string OpenFolderSelectArchivo()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var fileName = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                //openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    return filePath;
                    //Read the contents of the file into a stream
                    /*
			        var fileStream = openFileDialog.OpenFile();
			
			        using (StreamReader reader = new StreamReader(fileStream))
			        {
			            fileContent = reader.ReadToEnd();
			        }
			        */
                }
            }
            return "Error al acceder a la ruta";
        }


        public string ObtenerRutaArchivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el filtro para mostrar solo archivos .csv
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            openFileDialog.Title = "Seleccionar archivo CSV";
            openFileDialog.Multiselect = false; // Solo permitir seleccionar un archivo

            // Mostrar el diálogo y verificar el resultado
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // El usuario seleccionó un archivo y presionó "Abrir"
                return openFileDialog.FileName; // Devolver la ruta completa del archivo
            }
            else
            {
                // El usuario canceló la selección
                return null;
            }
        }

        public string[] OpenFolderSelectVariosArchivos()
        {
            string[] result;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "CSIDL_DEFAULT_DOWNLOADS";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                //openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.Multiselect = true;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    result = openFileDialog.FileNames;
                    return result;
                }
            }
            string[] resultadoError = new string[1] { "Error" };
            return resultadoError;
        }
        public string[] OpenFolderSelectVariosArchivos_Formato(string formato)
        {
            string[] result;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "CSIDL_DEFAULT_DOWNLOADS";
                //openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Filter = "csv files (*" + formato + ")|*" + formato + "";
                openFileDialog.Multiselect = true;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    result = openFileDialog.FileNames;
                    return result;
                }
            }
            string[] resultadoError = new string[1] { "Error" };
            return resultadoError;
        }
        public Boolean ExisteArchivo(string nombreActual, string ruta)
        {
            bool bandera = false;
            if (File.Exists(ruta + "/" + nombreActual))
            {
                return bandera = true;
            }
            else
            {
                return bandera = false;
            }
        }

        public Boolean ExisteDirectorio(string ruta)
        {
            bool bandera = false;
            if (Directory.Exists(ruta))
            {
                return bandera = true;
            }
            else
            {
                return bandera = false;
            }
        }

        public String RenombrarArchivo(string nombreActual, string nombreNuevo, string ruta)
        {
            string mensaje = string.Empty;
            if (File.Exists(ruta + "\\" + nombreNuevo))
            {
                return mensaje = "El Archivo ya Existe en el Directorio";
            }
            else
            {
                if (File.Exists(ruta + "\\" + nombreActual))
                {
                    System.IO.File.Move(ruta + "\\" + nombreActual, ruta + "\\" + nombreNuevo);
                    return mensaje = "Archivo Renombrado Exitosamente: " + nombreNuevo;
                }
                else
                {
                    return mensaje = "No existe el Archivo a Renombrar";
                }
            }
        }

        public String MoverArchivo(string nombreActual, string rutaActual, string rutaFinal)
        {
            string mensaje = string.Empty;
            if (File.Exists(rutaActual + "//" + nombreActual))
            {
                System.IO.File.Move(rutaActual + "//" + nombreActual, rutaFinal + "//" + nombreActual);
                return mensaje = "Archivo Movido Exitosamente";
            }
            else
            {
                return mensaje = "No existe el Archivo a Mover";
            }
        }

        /*public bool CopiarArchivo(string rutaOrigen, string rutaDestino, bool sobrescribir = true)
        {
            try
            {
                File.Copy(rutaOrigen, rutaDestino, sobrescribir);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al copiar el archivo: {ex.Message}");
                return false;
            }
        }*/

        public String CopiarArchivo(string nombreActual, string rutaActual, string rutaFinal)
        {
            string mensaje = string.Empty;
            if (File.Exists(rutaActual))
            {
                System.IO.File.Copy(rutaActual, rutaFinal + "//" + nombreActual);
                return mensaje = "Archivo Copiado Exitosamente";
            }
            else
            {
                return mensaje = "No existe el Archivo a Copiar";
            }
        }

        public String MoverDirectorio(string rutaActual, string rutaFinal)
        {
            string mensaje = string.Empty;
            if (Directory.Exists(rutaActual))
            {
                System.IO.Directory.Move(rutaActual, rutaFinal);
                return mensaje = "Carpeta Movida Exitosamente";
            }
            else
            {
                return mensaje = "No existe la Carpeta a Mover";
            }
        }

        public String EliminarArchivo(string nombreActual, string rutaActual)
        {
            string mensaje = string.Empty;
            if (File.Exists(rutaActual + "//" + nombreActual))
            {
                System.IO.File.Delete(rutaActual + "//" + nombreActual);
                return mensaje = "Archivo Eliminado Exitosamente";
            }
            else
            {
                return mensaje = "No existe el Archivo a Eliminar";
            }
        }

        public Boolean RecreaCarpeta(string rutaCarpeta)
        {
            bool bandera = false;
            if (Directory.Exists(rutaCarpeta))
            {
                System.IO.Directory.Delete(rutaCarpeta, true);
                System.IO.Directory.CreateDirectory(rutaCarpeta);
                return bandera = true;
            }
            else if (!Directory.Exists(rutaCarpeta))
            {
                System.IO.Directory.CreateDirectory(rutaCarpeta);
                return bandera = true;
            }
            else
            {
                return false;
            }
        }

        public Boolean EliminaCarpeta(string rutaCarpeta)
        {
            bool bandera = false;
            if (Directory.Exists(rutaCarpeta))
            {
                System.IO.Directory.Delete(rutaCarpeta, true);
                return bandera = true;
            }
            else if (!Directory.Exists(rutaCarpeta))
            {
                return bandera = true;
            }
            else
            {
                return false;
            }
        }

        /*public String DescomprimirArchivo_Basico(string nombreActual, string rutaActual)
        {
            string mensaje = string.Empty;
            try
            {
                if (File.Exists(rutaActual + "\\" + nombreActual))
                {
                    using (ZipFile zip = ZipFile.Read(rutaActual + "\\" + nombreActual))
                    {
                        zip.ExtractAll(rutaActual);
                        zip.Name.ToString();
                        zip.Dispose();
                    }
                    return mensaje = "Archivo Descomprimido Exitosamente";
                }
                else
                {
                    return mensaje = "No existe el Archivo a Descomprimir";
                }
            }
            catch (Exception ex)
            {
                return mensaje = "Error al descomprimir el archivo: " + ex.ToString();
            }

        }

        public String DescomprimirArchivo(string nombreActual, string nombreExtraido, string rutaActual)
        {
            string mensaje = "";
            try
            {
                if (File.Exists(rutaActual + "\\" + nombreExtraido))
                {
                    mensaje = "Ya Existe el archivo en el directorio";
                    return mensaje;
                }
                else if (File.Exists(rutaActual + "\\" + nombreActual))
                {
                    using (ZipFile zip = ZipFile.Read(rutaActual + "\\" + nombreActual))
                    {
                        zip.ExtractAll(rutaActual);
                        zip.Name.ToString();
                        zip.Dispose();
                    }
                    return mensaje = "Archivo Descomprimido Exitosamente";
                }
                else
                {
                    return mensaje = "No existe el Archivo a Descomprimir";
                }
            }
            catch (Exception ex)
            {
                return mensaje = "Error al descomprimir el archivo: " + ex.ToString();
            }

        }

        public Boolean ComprimirArchivo(string nombreActual, string path)
        {
            try
            {
                if (ExisteArchivo(nombreActual, path))
                {
                    string[] nombreArchivo = nombreActual.Split('.');
                    Directory.SetCurrentDirectory(path);
                    using (var zip = new Ionic.Zip.ZipFile())
                    {
                        zip.CompressionMethod = Ionic.Zip.CompressionMethod.Deflate;
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                        zip.UseZip64WhenSaving = Zip64Option.AsNecessary;

                        zip.AddFile(nombreActual);
                        zip.Save(nombreArchivo[0] + ".zip");
                        return true;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        */
        public String ObtieneCabecera(string nombreArchivo, string ruta)
        {
            string cabecera = string.Empty;
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(ruta + "/" + nombreArchivo))
            {
                int Countup = 0;
                while (!sr.EndOfStream)
                {
                    Countup++;
                    if (Countup == 1)
                    {
                        return cabecera = sr.ReadLine();
                    }
                }
            }

            return cabecera;
        }

        public char ObtieneDelimitador(string rutaArchivo, int numLineasAnalizar)
        {
            if (!File.Exists(rutaArchivo))
            {
                throw new FileNotFoundException($"El archivo no existe: {rutaArchivo}");
            }

            char[] posiblesDelimitadores = { ',', ';', '\t', '|' };
            Dictionary<char, int> conteoDelimitadores = posiblesDelimitadores.ToDictionary(d => d, d => 0);
            int lineasLeidas = 0;

            using (var reader = new StreamReader(rutaArchivo))
            {
                while (!reader.EndOfStream && lineasLeidas < numLineasAnalizar)
                {
                    string linea = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        foreach (char delimitador in posiblesDelimitadores)
                        {
                            conteoDelimitadores[delimitador] += linea.Count(c => c == delimitador);
                        }
                        lineasLeidas++;
                    }
                }
            }

            // Encontrar el delimitador con el conteo más alto
            char delimitadorDetectado = conteoDelimitadores.OrderByDescending(kvp => kvp.Value)
                                                          .FirstOrDefault()
                                                          .Key;

            return delimitadorDetectado;
        }

        public String[] ObtieneArchivosDirectorio(string ruta)
        {
            DirectoryInfo di = new DirectoryInfo(ruta);
            int contador = 0;
            foreach (var fi in di.GetFiles())
            {
                contador++;
            }
            string[] archivos = new string[contador];
            //Retorna Nombre de Todos los Archivos de una Carpeta
            contador = 0;
            foreach (var fi in di.GetFiles())
            {
                archivos[contador] = fi.Name.ToString();
                contador++;
            }
            return archivos;
        }
    }
}
