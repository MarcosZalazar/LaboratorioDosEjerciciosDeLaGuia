
namespace FrmTorneo
{
    partial class FrmTorneo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.cmbEquipoUno = new System.Windows.Forms.ComboBox();
            this.cmbEquipoDos = new System.Windows.Forms.ComboBox();
            this.btnDesafiar = new System.Windows.Forms.Button();
            this.rchtDatosTorneo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(12, 85);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowTemplate.Height = 25;
            this.dgvResultados.Size = new System.Drawing.Size(525, 235);
            this.dgvResultados.TabIndex = 0;
            // 
            // cmbEquipoUno
            // 
            this.cmbEquipoUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipoUno.FormattingEnabled = true;
            this.cmbEquipoUno.Location = new System.Drawing.Point(12, 27);
            this.cmbEquipoUno.Name = "cmbEquipoUno";
            this.cmbEquipoUno.Size = new System.Drawing.Size(249, 23);
            this.cmbEquipoUno.TabIndex = 1;
            this.cmbEquipoUno.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoUno_SelectedIndexChanged);
            // 
            // cmbEquipoDos
            // 
            this.cmbEquipoDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipoDos.FormattingEnabled = true;
            this.cmbEquipoDos.Location = new System.Drawing.Point(267, 27);
            this.cmbEquipoDos.Name = "cmbEquipoDos";
            this.cmbEquipoDos.Size = new System.Drawing.Size(249, 23);
            this.cmbEquipoDos.TabIndex = 2;
            // 
            // btnDesafiar
            // 
            this.btnDesafiar.Location = new System.Drawing.Point(143, 56);
            this.btnDesafiar.Name = "btnDesafiar";
            this.btnDesafiar.Size = new System.Drawing.Size(243, 23);
            this.btnDesafiar.TabIndex = 3;
            this.btnDesafiar.Text = "Jugar Partido";
            this.btnDesafiar.UseVisualStyleBackColor = true;
            this.btnDesafiar.Click += new System.EventHandler(this.btnDesafiar_Click);
            // 
            // rchtDatosTorneo
            // 
            this.rchtDatosTorneo.Location = new System.Drawing.Point(12, 326);
            this.rchtDatosTorneo.Name = "rchtDatosTorneo";
            this.rchtDatosTorneo.Size = new System.Drawing.Size(525, 171);
            this.rchtDatosTorneo.TabIndex = 4;
            this.rchtDatosTorneo.Text = "";
            // 
            // FrmTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 509);
            this.Controls.Add(this.rchtDatosTorneo);
            this.Controls.Add(this.btnDesafiar);
            this.Controls.Add(this.cmbEquipoDos);
            this.Controls.Add(this.cmbEquipoUno);
            this.Controls.Add(this.dgvResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competencias";
            this.Load += new System.EventHandler(this.FrmTorneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.ComboBox cmbEquipoUno;
        private System.Windows.Forms.ComboBox cmbEquipoDos;
        private System.Windows.Forms.Button btnDesafiar;
        private System.Windows.Forms.RichTextBox rchtDatosTorneo;
    }
}

