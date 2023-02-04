using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

    namespace Nomina
{
    public partial class Nomina : Form
    {
        
        public Nomina()
        {
            InitializeComponent();
        }
        int n = 0;

        public void LimpiarCelda()
        {
            txtID.Text = string.Empty;
            txtNom.Text = "";
            txtEmpleo.Text = "";
            txtSM.Text = "";
            txtDT.Text = string.Empty;
            txtHE.Text = string.Empty;
            txtBasico.Text = string.Empty;
            txtINSS.Text = string.Empty;
        }
        private void Nomina_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            int n = Nominadgtv.Rows.Add();

            Nominadgtv.Rows[n].Cells[0].Value = txtID.Text;
            Nominadgtv.Rows[n].Cells[1].Value = txtNom.Text;
            Nominadgtv.Rows[n].Cells[2].Value = txtEmpleo.Text;
            Nominadgtv.Rows[n].Cells[3].Value = txtSM.Text;
            Nominadgtv.Rows[n].Cells[4].Value = txtDT.Text;
            Nominadgtv.Rows[n].Cells[5].Value = txtHE.Text;

            double a, b, c, multiplicacion, division, inss;
            a = Double.Parse(txtSM.Text);
            b = Double.Parse(txtDT.Text);
            c = Double.Parse(txtHE.Text);

            multiplicacion = (a * b) / 30;
            txtBasico.Text = multiplicacion.ToString();

            division = (a * b) / 30;
            inss = division * 0.7;

            txtINSS.Text= inss.ToString();

            Nominadgtv.Rows[n].Cells[6].Value = txtBasico.Text;
            Nominadgtv.Rows[n].Cells[7].Value = txtINSS.Text;

            LimpiarCelda();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                Nominadgtv.Rows.RemoveAt(n);
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            Nominadgtv.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach(DataGridViewRow suma in Nominadgtv.Rows)
            {
                total += Convert.ToInt32(suma.Cells["Basico"].Value);
                txtToT.Text = Convert.ToString(total);
                txtToty.Text = Convert.ToString((Nominadgtv.Rows.Count));
            }
        }
    }
}
