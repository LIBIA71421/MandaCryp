using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandaCry_0._2
{
    public partial class Menu : Form
    {
        string namePlayer;
        public Menu(string v)
        {
            InitializeComponent();
            namePlayer = v;
            lbl_saludo.Text = "Hola" + v + "Estas en Mandacryp";
        }

        private void btn_algoritmos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Algoritmo tens = new Algoritmo();
            tens.ShowDialog();
        }

        private void btn_mensajeria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rb_RSA.Text) && !string.IsNullOrEmpty(rb_AES128.Text))
            {
                string v = "";
                this.Hide();
                if (rb_RSA.Checked)
                {
                    v = "RSA";
                    Mensaje est = new Mensaje(v);
                    est.ShowDialog();
                }
                else
                {
                    v = "AES128";
                    Mensaje sal = new Mensaje(v);
                    sal.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Elige un Nivel de Encriptacion ^^", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
