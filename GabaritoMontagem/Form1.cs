using System;
using System.Data;
using System.Windows.Forms;

namespace GabaritoMontagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tbComprimentoVertical.Enabled = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            lblResultBitolaHorizontal.Text = "-";
            lblResultBitolaVertical.Text = "-";
            lblAlerta.Text = "";

            double compHorizontal = Convert.ToInt32(tbComprimentoHorizontal.Text);

            double compVertical = tbComprimentoVertical.Text == "" ? 0 : Convert.ToInt32(tbComprimentoVertical.Text);

            bool raioMedio = cbRaioMedio.Checked;

            if (tbComprimentoVertical.Text == string.Empty)
            {
                if (cbRaioMedio.Checked)
                {
                    MessageBox.Show("Favor preencher o campo da barra vertical!");
                    tbComprimentoVertical.Focus();
                    return;
                }
                else
                    lblResultBitolaVertical.Text = "-";
            }
            else
            {
                lblResultBitolaVertical.Text = BancoDeDados.GetBitola(compVertical);
            }

            lblResultBitolaHorizontal.Text = BancoDeDados.GetBitola(compHorizontal, raioMedio);

            if (compHorizontal / 2500 > 1.77)
            {
                if (!cbRaioMedio.Checked)
                {
                    lblAlerta.Text = "É recomendável usar barra vertical!";
                    lblAlerta.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblAlerta.Text = "";
                }
            }
        }

        private void cbRaioMedio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRaioMedio.Checked)
            {
                tbComprimentoVertical.Enabled = true;
            }
            else
            {
                tbComprimentoVertical.Clear();
                tbComprimentoVertical.Enabled = false;
            }
        }
    }
}
