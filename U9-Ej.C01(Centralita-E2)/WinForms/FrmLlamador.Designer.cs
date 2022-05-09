namespace WinForms
{
    partial class FrmLlamador
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
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btnNroCero = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btnNroNueve = new System.Windows.Forms.Button();
            this.btnNroOcho = new System.Windows.Forms.Button();
            this.btnNroSiete = new System.Windows.Forms.Button();
            this.btnNroSeis = new System.Windows.Forms.Button();
            this.btnNroCinco = new System.Windows.Forms.Button();
            this.btnNroCuatro = new System.Windows.Forms.Button();
            this.btnNroTres = new System.Windows.Forms.Button();
            this.btnNroDos = new System.Windows.Forms.Button();
            this.btnNroUno = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNroDestino.Location = new System.Drawing.Point(22, 16);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(325, 36);
            this.txtNroDestino.TabIndex = 0;
            this.txtNroDestino.Text = "Nro Destino";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNumeral);
            this.groupBox1.Controls.Add(this.btnNroCero);
            this.groupBox1.Controls.Add(this.btnAsterisco);
            this.groupBox1.Controls.Add(this.btnNroNueve);
            this.groupBox1.Controls.Add(this.btnNroOcho);
            this.groupBox1.Controls.Add(this.btnNroSiete);
            this.groupBox1.Controls.Add(this.btnNroSeis);
            this.groupBox1.Controls.Add(this.btnNroCinco);
            this.groupBox1.Controls.Add(this.btnNroCuatro);
            this.groupBox1.Controls.Add(this.btnNroTres);
            this.groupBox1.Controls.Add(this.btnNroDos);
            this.groupBox1.Controls.Add(this.btnNroUno);
            this.groupBox1.Location = new System.Drawing.Point(22, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel";
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(108, 154);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(44, 38);
            this.btnNumeral.TabIndex = 11;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnNumeral_Click);
            // 
            // btnNroCero
            // 
            this.btnNroCero.Location = new System.Drawing.Point(58, 154);
            this.btnNroCero.Name = "btnNroCero";
            this.btnNroCero.Size = new System.Drawing.Size(44, 38);
            this.btnNroCero.TabIndex = 10;
            this.btnNroCero.Text = "0";
            this.btnNroCero.UseVisualStyleBackColor = true;
            this.btnNroCero.Click += new System.EventHandler(this.btnNroCero_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(8, 154);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(44, 38);
            this.btnAsterisco.TabIndex = 9;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnAsterisco_Click);
            // 
            // btnNroNueve
            // 
            this.btnNroNueve.Location = new System.Drawing.Point(108, 110);
            this.btnNroNueve.Name = "btnNroNueve";
            this.btnNroNueve.Size = new System.Drawing.Size(44, 38);
            this.btnNroNueve.TabIndex = 8;
            this.btnNroNueve.Text = "9";
            this.btnNroNueve.UseVisualStyleBackColor = true;
            this.btnNroNueve.Click += new System.EventHandler(this.btnNroNueve_Click);
            // 
            // btnNroOcho
            // 
            this.btnNroOcho.Location = new System.Drawing.Point(58, 110);
            this.btnNroOcho.Name = "btnNroOcho";
            this.btnNroOcho.Size = new System.Drawing.Size(44, 38);
            this.btnNroOcho.TabIndex = 7;
            this.btnNroOcho.Text = "8";
            this.btnNroOcho.UseVisualStyleBackColor = true;
            this.btnNroOcho.Click += new System.EventHandler(this.btnNroOcho_Click);
            // 
            // btnNroSiete
            // 
            this.btnNroSiete.Location = new System.Drawing.Point(8, 110);
            this.btnNroSiete.Name = "btnNroSiete";
            this.btnNroSiete.Size = new System.Drawing.Size(44, 38);
            this.btnNroSiete.TabIndex = 6;
            this.btnNroSiete.Text = "7";
            this.btnNroSiete.UseVisualStyleBackColor = true;
            this.btnNroSiete.Click += new System.EventHandler(this.btnNroSiete_Click);
            // 
            // btnNroSeis
            // 
            this.btnNroSeis.Location = new System.Drawing.Point(108, 66);
            this.btnNroSeis.Name = "btnNroSeis";
            this.btnNroSeis.Size = new System.Drawing.Size(44, 38);
            this.btnNroSeis.TabIndex = 5;
            this.btnNroSeis.Text = "6";
            this.btnNroSeis.UseVisualStyleBackColor = true;
            this.btnNroSeis.Click += new System.EventHandler(this.btnNroSeis_Click);
            // 
            // btnNroCinco
            // 
            this.btnNroCinco.Location = new System.Drawing.Point(58, 66);
            this.btnNroCinco.Name = "btnNroCinco";
            this.btnNroCinco.Size = new System.Drawing.Size(44, 38);
            this.btnNroCinco.TabIndex = 4;
            this.btnNroCinco.Text = "5";
            this.btnNroCinco.UseVisualStyleBackColor = true;
            this.btnNroCinco.Click += new System.EventHandler(this.btnNroCinco_Click);
            // 
            // btnNroCuatro
            // 
            this.btnNroCuatro.Location = new System.Drawing.Point(8, 66);
            this.btnNroCuatro.Name = "btnNroCuatro";
            this.btnNroCuatro.Size = new System.Drawing.Size(44, 38);
            this.btnNroCuatro.TabIndex = 3;
            this.btnNroCuatro.Text = "4";
            this.btnNroCuatro.UseVisualStyleBackColor = true;
            this.btnNroCuatro.Click += new System.EventHandler(this.btnNroCuatro_Click);
            // 
            // btnNroTres
            // 
            this.btnNroTres.Location = new System.Drawing.Point(108, 22);
            this.btnNroTres.Name = "btnNroTres";
            this.btnNroTres.Size = new System.Drawing.Size(44, 38);
            this.btnNroTres.TabIndex = 2;
            this.btnNroTres.Text = "3";
            this.btnNroTres.UseVisualStyleBackColor = true;
            this.btnNroTres.Click += new System.EventHandler(this.btnNroTres_Click);
            // 
            // btnNroDos
            // 
            this.btnNroDos.Location = new System.Drawing.Point(58, 22);
            this.btnNroDos.Name = "btnNroDos";
            this.btnNroDos.Size = new System.Drawing.Size(44, 38);
            this.btnNroDos.TabIndex = 1;
            this.btnNroDos.Text = "2";
            this.btnNroDos.UseVisualStyleBackColor = true;
            this.btnNroDos.Click += new System.EventHandler(this.btnNroDos_Click);
            // 
            // btnNroUno
            // 
            this.btnNroUno.Location = new System.Drawing.Point(8, 22);
            this.btnNroUno.Name = "btnNroUno";
            this.btnNroUno.Size = new System.Drawing.Size(44, 38);
            this.btnNroUno.TabIndex = 0;
            this.btnNroUno.Text = "1";
            this.btnNroUno.UseVisualStyleBackColor = true;
            this.btnNroUno.Click += new System.EventHandler(this.btnNroUno_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(205, 86);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(142, 34);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(205, 127);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(142, 34);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(204, 211);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Location = new System.Drawing.Point(204, 176);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(142, 23);
            this.txtNroOrigen.TabIndex = 5;
            this.txtNroOrigen.Text = "Nro Origen";
            // 
            // cmbFranja
            // 
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(22, 263);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(324, 23);
            this.cmbFranja.TabIndex = 6;
            this.cmbFranja.Text = "Franja";
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 298);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNroDestino);
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLlamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btnNroCero;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.Button btnNroNueve;
        private System.Windows.Forms.Button btnNroOcho;
        private System.Windows.Forms.Button btnNroSiete;
        private System.Windows.Forms.Button btnNroSeis;
        private System.Windows.Forms.Button btnNroCinco;
        private System.Windows.Forms.Button btnNroCuatro;
        private System.Windows.Forms.Button btnNroTres;
        private System.Windows.Forms.Button btnNroDos;
        private System.Windows.Forms.Button btnNroUno;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.ComboBox cmbFranja;
    }
}