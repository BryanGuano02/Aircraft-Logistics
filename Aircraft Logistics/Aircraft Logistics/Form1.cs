using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aircraft_Logistics
{
    public partial class Form1 : Form
    {
        struct Pasajero
        {
            string nombre;
            string Apellido;
            string tipoVuelo;
        };

        struct Destinos
        {
            string horaPartida;
            string destinos;
        };

       
         //Destinos[] ciudades =  { "Guayaquil-Ecuador", "1h", "Cuenca-Ecuador", "1h","Bogotá-Colombia", "1h 30min", "Lima-Perú", "2h 15min","Panamá-Panamá", "1h 50min" };
         //crear txt,exportarlos y hacer método Split

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCoprar.Enabled = false;
        }

        private void controlBotones()
        {
            if (nombreTxt.Text.Trim() != string.Empty && nombreTxt.Text.All(Char.IsLetter))
            {
                btnCoprar.Enabled = true;
                errorProvaider.SetError(nombreTxt, "");
            }
            else
            {
                if (!(nombreTxt.Text.All(Char.IsLetter)))
                {
                    errorProvaider.SetError(nombreTxt, "El nombre debe contener letras");
                }
                else
                {
                    errorProvaider.SetError(nombreTxt, "Debe introducir su nombre obligatoriamente");
                }
                btnCoprar.Enabled = false;
                nombreTxt.Focus();
            }

            if (apellidoTxt.Text.Trim() != string.Empty && apellidoTxt.Text.All(Char.IsLetter))
            {
                btnCoprar.Enabled = true;
                errorProvaider.SetError(apellidoTxt, "");
            }
            else
            {
                if (!(apellidoTxt.Text.All(Char.IsLetter)))
                {
                    errorProvaider.SetError(apellidoTxt, "El apellido debe contener letras");
                }
                else
                {
                    errorProvaider.SetError(apellidoTxt, "Debe introducir su apellido obligatoriamente");
                }
                btnCoprar.Enabled = false;
                apellidoTxt.Focus();

            }
        }

        private void controlBotones2()
        {

            if (apellidoTxt.Text.Trim() != string.Empty && apellidoTxt.Text.All(Char.IsLetter))
            {
                btnCoprar.Enabled = true;
                errorProvider2.SetError(apellidoTxt, "");
            }
            else
            {
                if (!(apellidoTxt.Text.All(Char.IsLetter)))
                {
                    errorProvider2.SetError(apellidoTxt, "El apellido debe contener letras");
                }
                else
                {
                    errorProvider2.SetError(apellidoTxt, "Debe introducir su apellido obligatoriamente");
                }
                btnCoprar.Enabled = false;
                apellidoTxt.Focus();

            }
        }

        //private void controlItemsDestinos


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void apellidoTxt_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}
