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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Double numero1, numero2;
            if ((Double.TryParse(txtNumero1.Text, out numero1)) && (Double.TryParse(txtNumero2.Text, out numero2))) {
                if ((numero1 >= 0) && (numero2 >= 0) && (numero2 >= numero1))
                {
                    Random objR = new Random();
                    double sorteado = objR.Next((int)numero1, (int)numero2);
                    MessageBox.Show("o número sorteado é:" + sorteado.ToString());
                }
                else
                    MessageBox.Show("Número inválido"); ;
            }
            else
                MessageBox.Show("Número inválido");
        }
    }
}
