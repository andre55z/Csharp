using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmenu
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverter1_Click(object sender, EventArgs e)
        {
            //cria um array de char a partir da sting
            char[] vetor = txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor);//inverte
            string auxiliar = new string(vetor);
            txtPalavra2.Text = auxiliar;
        }
    }
}
