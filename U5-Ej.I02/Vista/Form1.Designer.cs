namespace Vista
{
    partial class frmRegistro
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
            this.grbDetallesUsuario = new System.Windows.Forms.GroupBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lsbPais = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.radNoBinario = new System.Windows.Forms.RadioButton();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.grbCursos = new System.Windows.Forms.GroupBox();
            this.chkJavascript = new System.Windows.Forms.CheckBox();
            this.chkCPlusPlus = new System.Windows.Forms.CheckBox();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grbDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.grbGenero.SuspendLayout();
            this.grbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDetallesUsuario
            // 
            this.grbDetallesUsuario.Controls.Add(this.nudEdad);
            this.grbDetallesUsuario.Controls.Add(this.txtDireccion);
            this.grbDetallesUsuario.Controls.Add(this.txtNombre);
            this.grbDetallesUsuario.Controls.Add(this.lblEdad);
            this.grbDetallesUsuario.Controls.Add(this.lblDireccion);
            this.grbDetallesUsuario.Controls.Add(this.lblNombre);
            this.grbDetallesUsuario.Location = new System.Drawing.Point(37, 27);
            this.grbDetallesUsuario.Name = "grbDetallesUsuario";
            this.grbDetallesUsuario.Size = new System.Drawing.Size(247, 147);
            this.grbDetallesUsuario.TabIndex = 0;
            this.grbDetallesUsuario.TabStop = false;
            this.grbDetallesUsuario.Text = "Detalles del usuario";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(100, 99);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 23);
            this.nudEdad.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(100, 64);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(120, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(23, 107);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(23, 72);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lsbPais
            // 
            this.lsbPais.FormattingEnabled = true;
            this.lsbPais.ItemHeight = 15;
            this.lsbPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lsbPais.Location = new System.Drawing.Point(37, 223);
            this.lsbPais.Name = "lsbPais";
            this.lsbPais.Size = new System.Drawing.Size(247, 94);
            this.lsbPais.TabIndex = 1;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(37, 197);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "País";
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.radNoBinario);
            this.grbGenero.Controls.Add(this.radFemenino);
            this.grbGenero.Controls.Add(this.radMasculino);
            this.grbGenero.Location = new System.Drawing.Point(332, 27);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(139, 112);
            this.grbGenero.TabIndex = 3;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Género";
            // 
            // radNoBinario
            // 
            this.radNoBinario.AutoSize = true;
            this.radNoBinario.Location = new System.Drawing.Point(14, 74);
            this.radNoBinario.Name = "radNoBinario";
            this.radNoBinario.Size = new System.Drawing.Size(81, 19);
            this.radNoBinario.TabIndex = 2;
            this.radNoBinario.Text = "No binario";
            this.radNoBinario.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Location = new System.Drawing.Point(14, 49);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(78, 19);
            this.radFemenino.TabIndex = 1;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Checked = true;
            this.radMasculino.Location = new System.Drawing.Point(14, 24);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(80, 19);
            this.radMasculino.TabIndex = 0;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // grbCursos
            // 
            this.grbCursos.Controls.Add(this.chkJavascript);
            this.grbCursos.Controls.Add(this.chkCPlusPlus);
            this.grbCursos.Controls.Add(this.chkCSharp);
            this.grbCursos.Location = new System.Drawing.Point(334, 162);
            this.grbCursos.Name = "grbCursos";
            this.grbCursos.Size = new System.Drawing.Size(137, 100);
            this.grbCursos.TabIndex = 4;
            this.grbCursos.TabStop = false;
            this.grbCursos.Text = "Cursos";
            // 
            // chkJavascript
            // 
            this.chkJavascript.AutoSize = true;
            this.chkJavascript.Location = new System.Drawing.Point(12, 70);
            this.chkJavascript.Name = "chkJavascript";
            this.chkJavascript.Size = new System.Drawing.Size(77, 19);
            this.chkJavascript.TabIndex = 2;
            this.chkJavascript.Text = "Javascript";
            this.chkJavascript.UseVisualStyleBackColor = true;
            // 
            // chkCPlusPlus
            // 
            this.chkCPlusPlus.AutoSize = true;
            this.chkCPlusPlus.Location = new System.Drawing.Point(12, 47);
            this.chkCPlusPlus.Name = "chkCPlusPlus";
            this.chkCPlusPlus.Size = new System.Drawing.Size(50, 19);
            this.chkCPlusPlus.TabIndex = 1;
            this.chkCPlusPlus.Text = "C++";
            this.chkCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(12, 22);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(41, 19);
            this.chkCSharp.TabIndex = 0;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(370, 287);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(101, 30);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 340);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.grbCursos);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lsbPais);
            this.Controls.Add(this.grbDetallesUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.grbDetallesUsuario.ResumeLayout(false);
            this.grbDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grbCursos.ResumeLayout(false);
            this.grbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetallesUsuario;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.ListBox lsbPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.RadioButton radNoBinario;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.GroupBox grbCursos;
        private System.Windows.Forms.CheckBox chkJavascript;
        private System.Windows.Forms.CheckBox chkCPlusPlus;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.Button btnIngresar;
    }
}
