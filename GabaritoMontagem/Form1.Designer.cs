﻿namespace GabaritoMontagem
{
    partial class FormGabaritoMontagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGabaritoMontagem));
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
            this.cbGabarito = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComprimentoHorizontal
            // 
            this.lblComprimentoHorizontal.AutoSize = true;
            this.lblComprimentoHorizontal.Location = new System.Drawing.Point(16, 51);
            this.lblComprimentoHorizontal.Name = "lblComprimentoHorizontal";
            this.lblComprimentoHorizontal.Size = new System.Drawing.Size(118, 13);
            this.lblComprimentoHorizontal.TabIndex = 0;
            this.lblComprimentoHorizontal.Text = "Comprimento Horizontal";
            // 
            // lblComprimentoVertical
            // 
            this.lblComprimentoVertical.AutoSize = true;
            this.lblComprimentoVertical.Location = new System.Drawing.Point(16, 88);
            this.lblComprimentoVertical.Name = "lblComprimentoVertical";
            this.lblComprimentoVertical.Size = new System.Drawing.Size(106, 13);
            this.lblComprimentoVertical.TabIndex = 1;
            this.lblComprimentoVertical.Text = "Comprimento Vertical";
            // 
            // tbComprimentoHorizontal
            // 
            this.tbComprimentoHorizontal.Location = new System.Drawing.Point(140, 48);
            this.tbComprimentoHorizontal.Name = "tbComprimentoHorizontal";
            this.tbComprimentoHorizontal.Size = new System.Drawing.Size(100, 20);
            this.tbComprimentoHorizontal.TabIndex = 2;
            this.tbComprimentoHorizontal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbComprimentoHorizontal_KeyPress);
            // 
            // tbComprimentoVertical
            // 
            this.tbComprimentoVertical.Enabled = false;
            this.tbComprimentoVertical.Location = new System.Drawing.Point(140, 84);
            this.tbComprimentoVertical.Name = "tbComprimentoVertical";
            this.tbComprimentoVertical.Size = new System.Drawing.Size(100, 20);
            this.tbComprimentoVertical.TabIndex = 3;
            // 
            // lblBitolaHorizontal
            // 
            this.lblBitolaHorizontal.AutoSize = true;
            this.lblBitolaHorizontal.Location = new System.Drawing.Point(13, 130);
            this.lblBitolaHorizontal.Name = "lblBitolaHorizontal";
            this.lblBitolaHorizontal.Size = new System.Drawing.Size(83, 13);
            this.lblBitolaHorizontal.TabIndex = 6;
            this.lblBitolaHorizontal.Text = "Bitola Horizontal";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(140, 222);
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
            this.btnCancelar.Location = new System.Drawing.Point(47, 222);
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
            this.lblResultBitolaHorizontal.Location = new System.Drawing.Point(137, 130);
            this.lblResultBitolaHorizontal.Name = "lblResultBitolaHorizontal";
            this.lblResultBitolaHorizontal.Size = new System.Drawing.Size(0, 13);
            this.lblResultBitolaHorizontal.TabIndex = 9;
            // 
            // lblBitolaVertical
            // 
            this.lblBitolaVertical.AutoSize = true;
            this.lblBitolaVertical.Location = new System.Drawing.Point(13, 166);
            this.lblBitolaVertical.Name = "lblBitolaVertical";
            this.lblBitolaVertical.Size = new System.Drawing.Size(71, 13);
            this.lblBitolaVertical.TabIndex = 10;
            this.lblBitolaVertical.Text = "Bitola Vertical";
            // 
            // lblResultBitolaVertical
            // 
            this.lblResultBitolaVertical.AutoSize = true;
            this.lblResultBitolaVertical.Location = new System.Drawing.Point(137, 166);
            this.lblResultBitolaVertical.Name = "lblResultBitolaVertical";
            this.lblResultBitolaVertical.Size = new System.Drawing.Size(0, 13);
            this.lblResultBitolaVertical.TabIndex = 11;
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.ForeColor = System.Drawing.Color.Red;
            this.lblAlerta.Location = new System.Drawing.Point(44, 196);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(188, 13);
            this.lblAlerta.TabIndex = 12;
            this.lblAlerta.Text = "É Recomendável usar a barra vertical!";
            this.lblAlerta.Visible = false;
            // 
            // cbRaioMedio
            // 
            this.cbRaioMedio.AutoSize = true;
            this.cbRaioMedio.Enabled = false;
            this.cbRaioMedio.Location = new System.Drawing.Point(246, 87);
            this.cbRaioMedio.Name = "cbRaioMedio";
            this.cbRaioMedio.Size = new System.Drawing.Size(15, 14);
            this.cbRaioMedio.TabIndex = 13;
            this.cbRaioMedio.UseVisualStyleBackColor = true;
            this.cbRaioMedio.CheckedChanged += new System.EventHandler(this.cbRaioMedio_CheckedChanged);
            // 
            // cbGabarito
            // 
            this.cbGabarito.FormattingEnabled = true;
            this.cbGabarito.Items.AddRange(new object[] {
            "Engetower",
            "Gontijo",
            "Brametal"});
            this.cbGabarito.Location = new System.Drawing.Point(140, 12);
            this.cbGabarito.Name = "cbGabarito";
            this.cbGabarito.Size = new System.Drawing.Size(100, 21);
            this.cbGabarito.TabIndex = 14;
            this.cbGabarito.Text = "Engetower";
            this.cbGabarito.SelectedValueChanged += new System.EventHandler(this.cbGabarito_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gabarito";
            // 
            // FormGabaritoMontagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGabarito);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGabaritoMontagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gabarito de Montagem";
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
        private System.Windows.Forms.ComboBox cbGabarito;
        private System.Windows.Forms.Label label1;
    }
}

