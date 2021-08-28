using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;

namespace AppSchool
{
    public partial class Login : Form
    {
        DatosEstudiate datos = new DatosEstudiate();
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUser.Text;
                string Pass = txtPass.Text;
                bool reult = datos.login(user, Pass);
                if (reult == true)
                {
                    AppSchool school = new AppSchool();
                    school.padre = txtUser.Text;
                    school.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas.");
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void lblNewUser_Click(object sender, EventArgs e)
        {
            Nuevo_usuario nuevo = new Nuevo_usuario();
            nuevo.ShowDialog();
        }
    }
}
