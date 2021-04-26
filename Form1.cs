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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_SALIR_Click(object sender, EventArgs e)
        {
            const string message = "seguro que quiere salir ?";
            const string til = "PREGUNTA";

            var mensaje = MessageBox.Show(message, til, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensaje == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btn_Validacion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_name.Text) && !string.IsNullOrEmpty(txt_Password.Text))
            {
                if (txt_name.ToString() == "ESTIB" && txt_Password.ToString() == "assd")
                {
                    string v = txt_name.Text;
                    MessageBox.Show("Registro Exitoso", "CONTINUAMOS......", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    Menu est = new Menu(v);
                    est.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No estas Registrado :/", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrea tus Datos!!!.... ^^", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Algoritmos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Algoritmo est = new Algoritmo();
            est.ShowDialog();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
