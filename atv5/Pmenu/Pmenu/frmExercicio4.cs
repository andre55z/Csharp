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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int tamanho =rchtxtFrase.Text.Length;
            int contanumero = 0;
            while (contador < tamanho) 
            {
                if (char.IsNumber(rchtxtFrase.Text[contador])){
                    contanumero++;
                }
                contador++;
            }
            MessageBox.Show("Existem "+contanumero+ " números");
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int tamanho = rchtxtFrase.Text.Length;
            int contaletra = 0;
            while (contador < tamanho)
            {
                if (char.IsLetter(rchtxtFrase.Text[contador]))
                {
                    contaletra++;
                }
                contador++;
            }
            MessageBox.Show("Existem " + contaletra + " letras");
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int tamanho = rchtxtFrase.Text.Length;
            while (contador < tamanho)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[contador]))
                {
                    MessageBox.Show("O primeiro espaço em branco está na " + (contador+1) + " posição") ;
                }
                contador++;
            }
        }
    }
    }
    

