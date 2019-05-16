namespace GabaritoMontagem
{
    partial class Form1
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
            this.lblComprimentoHorizontal = new System.Windows.Forms.Label();
            this.lblComprimentoVertical = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbBarraVertical = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblBitola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComprimentoHorizontal
            // 
            this.lblComprimentoHorizontal.AutoSize = true;
            this.lblComprimentoHorizontal.Location = new System.Drawing.Point(13, 18);
            this.lblComprimentoHorizontal.Name = "lblComprimentoHorizontal";
            this.lblComprimentoHorizontal.Size = new System.Drawing.Size(118, 13);
            this.lblComprimentoHorizontal.TabIndex = 0;
            this.lblComprimentoHorizontal.Text = "Comprimento Horizontal";
            // 
            // lblComprimentoVertical
            // 
            this.lblComprimentoVertical.AutoSize = true;
            this.lblComprimentoVertical.Location = new System.Drawing.Point(13, 54);
            this.lblComprimentoVertical.Name = "lblComprimentoVertical";
            this.lblComprimentoVertical.Size = new System.Drawing.Size(106, 13);
            this.lblComprimentoVertical.TabIndex = 1;
            this.lblComprimentoVertical.Text = "Comprimento Vertical";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // cbBarraVertical
            // 
            this.cbBarraVertical.AutoSize = true;
            this.cbBarraVertical.Location = new System.Drawing.Point(13, 90);
            this.cbBarraVertical.Name = "cbBarraVertical";
            this.cbBarraVertical.Size = new System.Drawing.Size(70, 13);
            this.cbBarraVertical.TabIndex = 4;
            this.cbBarraVertical.Text = "Barra Vertical";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(137, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblBitola
            // 
            this.lblBitola.AutoSize = true;
            this.lblBitola.Location = new System.Drawing.Point(13, 127);
            this.lblBitola.Name = "lblBitola";
            this.lblBitola.Size = new System.Drawing.Size(33, 13);
            this.lblBitola.TabIndex = 6;
            this.lblBitola.Text = "Bitola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBitola);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbBarraVertical);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblComprimentoVertical);
            this.Controls.Add(this.lblComprimentoHorizontal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComprimentoHorizontal;
        private System.Windows.Forms.Label lblComprimentoVertical;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label cbBarraVertical;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblBitola;
    }
}

