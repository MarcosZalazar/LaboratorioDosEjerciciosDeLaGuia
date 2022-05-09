namespace Vista
{
    partial class FormConversor
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
            this.lblBinToDec = new System.Windows.Forms.Label();
            this.lblDecToBin = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinToDec
            // 
            this.lblBinToDec.AutoSize = true;
            this.lblBinToDec.Location = new System.Drawing.Point(17, 24);
            this.lblBinToDec.Name = "lblBinToDec";
            this.lblBinToDec.Size = new System.Drawing.Size(99, 15);
            this.lblBinToDec.TabIndex = 0;
            this.lblBinToDec.Text = "Binario a Decimal";
            // 
            // lblDecToBin
            // 
            this.lblDecToBin.AutoSize = true;
            this.lblDecToBin.Location = new System.Drawing.Point(17, 60);
            this.lblDecToBin.Name = "lblDecToBin";
            this.lblDecToBin.Size = new System.Drawing.Size(99, 15);
            this.lblDecToBin.TabIndex = 1;
            this.lblDecToBin.Text = "Decimal a Binario";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(144, 16);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 23);
            this.txtBinario.TabIndex = 2;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(144, 57);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 23);
            this.txtDecimal.TabIndex = 3;
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(278, 16);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(75, 23);
            this.btnBinToDec.TabIndex = 4;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(278, 56);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(75, 23);
            this.btnDecToBin.TabIndex = 5;
            this.btnDecToBin.Text = "->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Enabled = false;
            this.txtResultadoDec.Location = new System.Drawing.Point(383, 16);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoDec.TabIndex = 6;
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Enabled = false;
            this.txtResultadoBin.Location = new System.Drawing.Point(383, 56);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(100, 23);
            this.txtResultadoBin.TabIndex = 7;
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 94);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblDecToBin);
            this.Controls.Add(this.lblBinToDec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numérico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinToDec;
        private System.Windows.Forms.Label lblDecToBin;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.TextBox txtResultadoBin;
    }
}
