using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_TEST
{
    public partial class FormParametrage : Form
    {
        public FormParametrage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rdoMasqueBinaire_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! IMPORTANT !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void btnCalculer_Click(object sender, EventArgs e)
        {
            //Si IP et masque valides alors
            FormResultat frmRes = new FormResultat();
            frmRes.Show();
            this.Hide();

            //Sinon si erreur IP
            lblMessageErreurIP.Visible = true;

            //Sinon si erreur masque
            lblMessageErreurMasque.Visible = true;

            //Sinon les deux.

        }

        private void lblMasque2_Click(object sender, EventArgs e)
        {

        }

        private void rdoIpBinaire_CheckedChanged(object sender, EventArgs e)
        {
            txtIP.Enabled = true;
        }

        private void rdoIPdecimal_CheckedChanged(object sender, EventArgs e)
        {
            txtIP.Enabled = true;
        }

        private void rdoIpHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            txtIP.Enabled = true;
        }

        private void rdoMasqueDecimal_CheckedChanged(object sender, EventArgs e)
        {
            txtMasque.Enabled = true;
        }
        private void rdoMasqueHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            txtMasque.Enabled = true;
        }

        private void rdoMasqueBinaire_CheckedChanged_1(object sender, EventArgs e)
        {
            txtMasque.Enabled = true;
        }

        private void rdoMasqueCIDR_CheckedChanged(object sender, EventArgs e)
        {
            txtMasque.Enabled = true;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            pnlConvertirIP.Visible = !pnlConvertirIP.Visible;
            pnlConvertirMasque.Visible = !pnlConvertirMasque.Visible;
        }
    }
}
