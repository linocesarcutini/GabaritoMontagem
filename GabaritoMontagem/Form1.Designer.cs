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
            this.tbComprimentoHorizontal = new System.Windows.Forms.TextBox();
            this.tbComprimentoVertical = new System.Windows.Forms.TextBox();
            this.lblBitolaHorizontal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblResultBitolaHorizontal = new System.Windows.Forms.Label();
            this.lblBitolaVertical = new System.Windows.Forms.Label();
            this.lblResultBitolaVertical = new System.Windows.Forms.Label();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.cbRaioMedio = new System.Windows.Forms.CheckBox();
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
            // tbComprimentoHorizontal
            // 
            this.tbComprimentoHorizontal.Location = new System.Drawing.Point(137, 15);
            this.tbComprimentoHorizontal.Name = "tbComprimentoHorizontal";
            this.tbComprimentoHorizontal.Size = new System.Drawing.Size(100, 20);
            this.tbComprimentoHorizontal.TabIndex = 2;
            // 
            // tbComprimentoVertical
            // 
            this.tbComprimentoVertical.Location = new System.Drawing.Point(137, 51);
            this.tbComprimentoVertical.Name = "tbComprimentoVertical";
            this.tbComprimentoVertical.Size = new System.Drawing.Size(100, 20);
            this.tbComprimentoVertical.TabIndex = 3;
            // 
            // lblBitolaHorizontal
            // 
            this.lblBitolaHorizontal.AutoSize = true;
            this.lblBitolaHorizontal.Location = new System.Drawing.Point(13, 90);
            this.lblBitolaHorizontal.Name = "lblBitolaHorizontal";
            this.lblBitolaHorizontal.Size = new System.Drawing.Size(83, 13);
            this.lblBitolaHorizontal.TabIndex = 6;
            this.lblBitolaHorizontal.Text = "Bitola Horizontal";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(173, 197);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(92, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblResultBitolaHorizontal
            // 
            this.lblResultBitolaHorizontal.AutoSize = true;
            this.lblResultBitolaHorizontal.Location = new System.Drawing.Point(137, 90);
            this.lblResultBitolaHorizontal.Name = "lblResultBitolaHorizontal";
            this.lblResultBitolaHorizontal.Size = new System.Drawing.Size(0, 13);
            this.lblResultBitolaHorizontal.TabIndex = 9;
            // 
            // lblBitolaVertical
            // 
            this.lblBitolaVertical.AutoSize = true;
            this.lblBitolaVertical.Location = new System.Drawing.Point(13, 126);
            this.lblBitolaVertical.Name = "lblBitolaVertical";
            this.lblBitolaVertical.Size = new System.Drawing.Size(71, 13);
            this.lblBitolaVertical.TabIndex = 10;
            this.lblBitolaVertical.Text = "Bitola Vertical";
            // 
            // lblResultBitolaVertical
            // 
            this.lblResultBitolaVertical.AutoSize = true;
            this.lblResultBitolaVertical.Location = new System.Drawing.Point(137, 126);
            this.lblResultBitolaVertical.Name = "lblResultBitolaVertical";
            this.lblResultBitolaVertical.Size = new System.Drawing.Size(0, 13);
            this.lblResultBitolaVertical.TabIndex = 11;
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Location = new System.Drawing.Point(13, 162);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(0, 13);
            this.lblAlerta.TabIndex = 12;
            // 
            // cbRaioMedio
            // 
            this.cbRaioMedio.AutoSize = true;
            this.cbRaioMedio.Location = new System.Drawing.Point(244, 18);
            this.cbRaioMedio.Name = "cbRaioMedio";
            this.cbRaioMedio.Size = new System.Drawing.Size(15, 14);
            this.cbRaioMedio.TabIndex = 13;
            this.cbRaioMedio.UseVisualStyleBackColor = true;
            this.cbRaioMedio.CheckedChanged += new System.EventHandler(this.cbRaioMedio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 232);
            this.Controls.Add(this.cbRaioMedio);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.lblResultBitolaVertical);
            this.Controls.Add(this.lblBitolaVertical);
            this.Controls.Add(this.lblResultBitolaHorizontal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblBitolaHorizontal);
            this.Controls.Add(this.tbComprimentoVertical);
            this.Controls.Add(this.tbComprimentoHorizontal);
            this.Controls.Add(this.lblComprimentoVertical);
            this.Controls.Add(this.lblComprimentoHorizontal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComprimentoHorizontal;
        private System.Windows.Forms.Label lblComprimentoVertical;
        private System.Windows.Forms.TextBox tbComprimentoHorizontal;
        private System.Windows.Forms.TextBox tbComprimentoVertical;
        private System.Windows.Forms.Label lblBitolaHorizontal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblResultBitolaHorizontal;
        private System.Windows.Forms.Label lblBitolaVertical;
        private System.Windows.Forms.Label lblResultBitolaVertical;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.CheckBox cbRaioMedio;
    }
}

