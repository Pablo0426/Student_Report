﻿using System;
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
    public partial class Nuevo_usuario : Form
    {
        DatosEstudiate datos = new DatosEstudiate();
        public Nuevo_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string pass = txtpass.Text;

            datos.AddUser(name, pass);
            MessageBox.Show("Usurio creado.");
            this.Close();
        }
    }
}
