using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_num_ps
{
    public partial class Generador : Form
    {
        public Generador()
        {
            InitializeComponent();
        }

        public bool verificador()
        {
            if (numSemilla.Value == 0 || numA.Value == 0 || numC.Value == 0 || numM.Value == 0 || numN.Value == 0)
            {
                MessageBox.Show("Los valores no pueden ser iguales a cero \nCambie los valores e intente de nuevo", "Error", MessageBoxButtons.OK);
                return true;
            }
            else if (numM.Value < numA.Value || numM.Value < numSemilla.Value || numM.Value < numC.Value)
            {
                MessageBox.Show("El malor de 'M' no puede ser menor que los demas.", "Error", MessageBoxButtons.OK);
                return true;
            }
            else return false;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TablaResulatdos.Rows.Clear();
            double N, A, C, M, Xo,Xn1;
            double R;
            if (verificador()) { return; }

            N = Convert.ToInt32(numN.Value);
            A = Convert.ToInt32(numA.Value);
            C = Convert.ToInt32(numC.Value);
            M = Convert.ToInt32(numM.Value);
            Xo = Convert.ToInt32(numSemilla.Value);

      


            for (int i = 1; i <= N; i++)
            {
                Xn1 = (A * (Xo + C)) % M;
                R = Xn1 / M;

                TablaResulatdos.Rows.Add(i, Xo, Xn1,String.Format("{0:F4}",R));

                Xo = Xn1;
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void numSemilla_Enter(object sender, EventArgs e)
        {
            numSemilla.Select(0,4);
        }

        private void numA_Enter(object sender, EventArgs e)
        {
            numA.Select(0, 4);
        }

        private void numC_Enter(object sender, EventArgs e)
        {
            numC.Select(0, 4);
        }

        private void numM_Enter(object sender, EventArgs e)
        {
            numM.Select(0, 4);
        }

        private void numN_Enter(object sender, EventArgs e)
        {
            numN.Select(0, 4);
        }
    }



}
