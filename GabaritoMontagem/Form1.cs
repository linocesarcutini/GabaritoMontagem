using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GabaritoMontagem
{
    public partial class FormGabaritoMontagem : Form
    {
        private static List<BarrasBrametal_Gontijo> GabaritoBrametalGontijo;
        private static List<BarrasEngetower> GabaritoEngetower;
        public FormGabaritoMontagem()
        {
            InitializeComponent();
            ConstruirListasDeGabaritos();
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
            double raio;
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
                raio = compVertical / 2500;

                foreach (BarrasBrametal_Gontijo item in GabaritoBrametalGontijo)
                {
                    if (item.rg_min > raio)
                    {
                        lblResultBitolaVertical.Text = item.bitola;
                        break;
                    }
                }
            }


            if (cbGabarito.SelectedItem.ToString().ToLower() == "engetower")
            {

                lblResultBitolaHorizontal.Text = SearchPerfil_Engetower(compHorizontal);
            }
            else
            {

                raio = compHorizontal / 2500;
                string raioResult = raioMedio ? "rg_med" : "rg_min";
                lblResultBitolaHorizontal.Text = SearchPerfil_Brametal_Gontijo(raio, raioResult);
            }

            if (compHorizontal / 2500 > 1.77)
            {
                if (!cbRaioMedio.Checked)
                {
                    lblAlerta.Visible = true;
                }
                else
                {
                    lblAlerta.Visible = false;
                }
            }
        }

        private string SearchPerfil_Brametal_Gontijo(double raio, string RaioResult)
        {
            if (RaioResult == "rg_med")
            {
                foreach (BarrasBrametal_Gontijo item in GabaritoBrametalGontijo)
                {

                    if (Convert.ToDouble(item.rg_med) > raio)
                    {
                        return item.bitola;
                    }
                }
            }
            else
            {
                foreach (BarrasBrametal_Gontijo item in GabaritoBrametalGontijo)
                {
                    if (Convert.ToDouble(item.rg_min) > raio)
                    {
                        return item.bitola;
                    }
                }
            }
            MessageBox.Show("comprimento inválido!");
            return "-";
        }

        private string SearchPerfil_Engetower(double ComprimentoHorizontal)
        {
            for (int i = 0; i < GabaritoEngetower.Count; i++)
            {
                if (GabaritoEngetower[i].rg_max >= ComprimentoHorizontal)
                {
                    return GabaritoEngetower[i].bitola;
                }
            }
            MessageBox.Show("comprimento inválido!");
            return "-";
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
        private void ConstruirListasDeGabaritos()
        {
            GabaritoBrametalGontijo = new List<BarrasBrametal_Gontijo>();

            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 0.78, rg_med = 1.21, bitola = "L 40 x 3" });
            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 0.87, rg_med = 1.36, bitola = "L 45 x 3" });
            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 0.99, rg_med = 1.52, bitola = "L 50 x 3" });
            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 1.17, rg_med = 1.83, bitola = "L 60 x 4" });
            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 1.27, rg_med = 1.98, bitola = "L 65 x 4" });
            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 1.47, rg_med = 2.3, bitola = "L 75 x 5" });
            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 1.77, rg_med = 2.75, bitola = "L 90 x 6" });
            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 1.97, rg_med = 3.07, bitola = "L 100 x 6" });
            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 2.51, rg_med = 3.99, bitola = "L 127 x 7.9" });
            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 3.02, rg_med = 4.78, bitola = "L 152 x 9.5" });
            GabaritoBrametalGontijo.Add(new BarrasBrametal_Gontijo() { rg_min = 4.04, rg_med = 6.35, bitola = "L 203 x 12.7" });

            GabaritoEngetower = new List<BarrasEngetower>();

            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 2340, bitola = "L 40 x 3" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 2640, bitola = "L 45 x 3" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 2970, bitola = "L 50 x 3" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 3570, bitola = "L 60 x 4" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 3900, bitola = "L 65 x 4" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 4440, bitola = "L 75 x 5" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 6230, bitola = "L 90 x 6" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 6930, bitola = "L 100 x 6" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 8785, bitola = "L 127 x 7.9" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 9660, bitola = "2L 90 x 6" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 10710, bitola = "2L 100 x 6" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 13860, bitola = "2L 127 x 7.9" });
            GabaritoEngetower.Add(new BarrasEngetower() { rg_max = 16730, bitola = "2L 152 x 9.5" });
        }

        private void cbGabarito_SelectedValueChanged(object sender, EventArgs e)
        {
            cbRaioMedio.Checked = false;
            if (cbGabarito.SelectedItem.ToString().ToLower() == "brametal")
            {
                cbRaioMedio.Enabled = true;
            }
            else
            {
                tbComprimentoVertical.Enabled = false;
                cbRaioMedio.Enabled = false;
            }
        }

        private void tbComprimentoHorizontal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnCalcular_Click(sender, e);
            }
        }
    }
}
