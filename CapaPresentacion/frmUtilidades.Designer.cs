namespace CapaPresentacion
{
    partial class frmUtilidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrueba = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelActualizacionLog = new System.Windows.Forms.Label();
            this.textBoxNombreTabla = new System.Windows.Forms.TextBox();
            this.labelNombreTabla = new System.Windows.Forms.Label();
            this.groupBoxInsertarArchivo = new System.Windows.Forms.GroupBox();
            this.groupBoxActividadActual = new System.Windows.Forms.GroupBox();
            this.labelActividadActual = new System.Windows.Forms.Label();
            this.groupBoxActividadActual.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(18, 109);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(154, 25);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Seleccionar Archivo";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.Location = new System.Drawing.Point(828, 51);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(414, 376);
            this.textBoxLog.TabIndex = 4;
            // 
            // labelActualizacionLog
            // 
            this.labelActualizacionLog.BackColor = System.Drawing.SystemColors.Window;
            this.labelActualizacionLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualizacionLog.Location = new System.Drawing.Point(828, 28);
            this.labelActualizacionLog.Name = "labelActualizacionLog";
            this.labelActualizacionLog.Size = new System.Drawing.Size(414, 20);
            this.labelActualizacionLog.TabIndex = 5;
            this.labelActualizacionLog.Text = "Log";
            this.labelActualizacionLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNombreTabla
            // 
            this.textBoxNombreTabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombreTabla.Location = new System.Drawing.Point(18, 83);
            this.textBoxNombreTabla.Name = "textBoxNombreTabla";
            this.textBoxNombreTabla.Size = new System.Drawing.Size(154, 20);
            this.textBoxNombreTabla.TabIndex = 6;
            // 
            // labelNombreTabla
            // 
            this.labelNombreTabla.AutoSize = true;
            this.labelNombreTabla.BackColor = System.Drawing.SystemColors.Window;
            this.labelNombreTabla.Location = new System.Drawing.Point(44, 64);
            this.labelNombreTabla.Name = "labelNombreTabla";
            this.labelNombreTabla.Size = new System.Drawing.Size(96, 13);
            this.labelNombreTabla.TabIndex = 7;
            this.labelNombreTabla.Text = "Nombre de la tabla";
            // 
            // groupBoxInsertarArchivo
            // 
            this.groupBoxInsertarArchivo.BackColor = System.Drawing.Color.White;
            this.groupBoxInsertarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInsertarArchivo.Location = new System.Drawing.Point(12, 34);
            this.groupBoxInsertarArchivo.Name = "groupBoxInsertarArchivo";
            this.groupBoxInsertarArchivo.Size = new System.Drawing.Size(166, 121);
            this.groupBoxInsertarArchivo.TabIndex = 8;
            this.groupBoxInsertarArchivo.TabStop = false;
            this.groupBoxInsertarArchivo.Text = "Insertar Archivo";
            // 
            // groupBoxActividadActual
            // 
            this.groupBoxActividadActual.BackColor = System.Drawing.Color.White;
            this.groupBoxActividadActual.Controls.Add(this.labelActividadActual);
            this.groupBoxActividadActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxActividadActual.Location = new System.Drawing.Point(828, 449);
            this.groupBoxActividadActual.Name = "groupBoxActividadActual";
            this.groupBoxActividadActual.Size = new System.Drawing.Size(414, 100);
            this.groupBoxActividadActual.TabIndex = 9;
            this.groupBoxActividadActual.TabStop = false;
            this.groupBoxActividadActual.Text = "Actividad Actual";
            // 
            // labelActividadActual
            // 
            this.labelActividadActual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelActividadActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActividadActual.Location = new System.Drawing.Point(6, 20);
            this.labelActividadActual.Name = "labelActividadActual";
            this.labelActividadActual.Size = new System.Drawing.Size(402, 73);
            this.labelActividadActual.TabIndex = 0;
            // 
            // frmUtilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 564);
            this.Controls.Add(this.groupBoxActividadActual);
            this.Controls.Add(this.labelNombreTabla);
            this.Controls.Add(this.textBoxNombreTabla);
            this.Controls.Add(this.labelActualizacionLog);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.groupBoxInsertarArchivo);
            this.Name = "frmUtilidades";
            this.Text = "frmUtilidades";
            this.Load += new System.EventHandler(this.frmUtilidades_Load);
            this.groupBoxActividadActual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelActualizacionLog;
        private System.Windows.Forms.TextBox textBoxNombreTabla;
        private System.Windows.Forms.Label labelNombreTabla;
        private System.Windows.Forms.GroupBox groupBoxInsertarArchivo;
        private System.Windows.Forms.GroupBox groupBoxActividadActual;
        private System.Windows.Forms.Label labelActividadActual;
    }
}