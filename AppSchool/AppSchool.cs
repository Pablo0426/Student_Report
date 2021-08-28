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
    public partial class AppSchool : Form
    {
        DatosEstudiate datos = new DatosEstudiate();
        public string padre;
        public AppSchool()
        {
            InitializeComponent();
        }

        private void AppSchool_Load(object sender, EventArgs e)
        {
            getInfo();
        }

        private void getInfo()
        {
            BindingSource source = new BindingSource();
            source.DataSource = datos.getEstudiante(padre);

            dataGridView1.DataSource = source;
        }
    }
}
