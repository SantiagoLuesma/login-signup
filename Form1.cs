using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_signup
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string userPassword = password.Text;

            while (username.Trim() == "" || userPassword.Trim() == "")
            {
                MessageBox.Show("Ambos campos deben ser completados.");
                userName.Focus();
                return;
            }

            if (username == "demo" && userPassword == "1234")
            {
                MessageBox.Show("Ingreso exitoso.");
                userName.Clear();
                password.Clear();
                userName.Focus();
            }
            else
            {
                MessageBox.Show("El nombre de usuario o la contraseña son incorrectos, inténtelo nuevamente.");
                userName.Clear();
                password.Clear();
                userName.Focus();
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
