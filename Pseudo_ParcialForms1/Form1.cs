using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace Pseudo_ParcialForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double h, r, g, v, a;
        private void OK_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            
            g = ValidarDatosG();

            h = ValidarDatosH();

            r = ValidarDatosR();


            if (g >= h || g >= r)
             {
                if(verificarCono(h, r, g))
                { 
                    a = Math.PI * r * (r + g);
                    v = (Math.PI * Math.Pow(r, 2) * h) / 3;

                    a = Math.Truncate(a);
                    v = Math.Truncate(v);
                }
                else
                {
                    errorProvider1.SetError(radio, "no es un cono");
                    errorProvider1.SetError(generatriz, "no es un cono");
                    errorProvider1.SetError(altura, "no es un cono");
                }
            }
            

            MostrarInfo();
            inicializarControles();
            

        }

        private bool verificarCono(double h, double r, double g)
        {
            Boolean result;
            result = (Math.Pow(h, 2) + Math.Pow(r, 2) == Math.Pow(g, 2));
            return result;
        }

        private void MostrarInfo()
        {
            ResultA.Text = a.ToString();
            ResultV.Text = v.ToString();
        }

        private void inicializarControles()
        {
            generatriz.Clear();
            generatriz.Focus();
            altura.Clear();
            radio.Clear();
        }


        private double ValidarDatosH()
        {
            double nroH;
            

            if (!double.TryParse(altura.Text, out nroH))
            {
                errorProvider1.SetError(altura, "Digito mal ingresado");
            }
            return nroH;
        }

        private double ValidarDatosR()
        {
            double nroR;
            

            if (!double.TryParse(radio.Text, out nroR))
            {
              
                errorProvider1.SetError(radio, "Digito mal ingresado");
            }
            return nroR;
        }

        private double ValidarDatosG()
        {

            double nroG;

            if (!double.TryParse(generatriz.Text, out nroG))
            {

                errorProvider1.SetError(generatriz, "Digito mal ingresado");
            }
            return nroG;
        }
    }
}
