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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            int metade = (txtPalavra2.Text.Length) / 2;
            int tamanho = (txtPalavra2.Text.Length);
            string palavraatualizada = txtPalavra2.Text.Substring(0, metade) + txtPalavra1.Text + txtPalavra2.Text.Substring(metade, txtPalavra2.Text.Length - metade);
            MessageBox.Show(palavraatualizada);
        }

        private void btnIguais_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true ) == 0)
            {
                MessageBox.Show("Iguais");
            }
            else
                MessageBox.Show("Diferentes");
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            int metade = (txtPalavra1.Text.Length) / 2;
            int tamanho = (txtPalavra1.Text.Length);
            string palavraAtualizada =txtPalavra1.Text.Substring(0, metade) + "**" + txtPalavra1.Text.Substring(metade, txtPalavra1.Text.Length - metade);
            MessageBox.Show(palavraAtualizada);
        }
    }
}
