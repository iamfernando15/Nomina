using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class Form1 : Form
    {
        Nomina formularioNomina; 
        public Form1()
        {
            InitializeComponent();
            formularioNomina = new Nomina(); 
        }
        int intentos = 0;
        string usuario = "admin";
        string contraseña = "12345";
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string password = txtpass.Text;

            if (password.Equals(contraseña) && user.Equals(usuario))
            {
                MessageBox.Show("Bienvenido");
                formularioNomina.ShowDialog();
            }
            else
            {
               DialogResult respuesta= MessageBox.Show("Datos incorrectos", "Ingresaste datos erroneos", 
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtuser.Clear();
                txtpass.Clear();

                if (respuesta == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                if (respuesta == DialogResult.Retry)
                {
                    intentos++;
                    txtuser.Clear();
                    txtpass.Clear();
                    if (intentos == 3)
                    {
                        MessageBox.Show("Alcanzo el maximo de intentos");
                        Application.Exit();
                    }

                }
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <=47) || (e.KeyChar >=58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
