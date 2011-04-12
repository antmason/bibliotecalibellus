using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyLlibellus
{
    public partial class frm_llibreriaPersonal : Form
    {
        public frm_llibreriaPersonal()
        {
            InitializeComponent();
        }

        private void frm_llibreriaPersonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Llibre' Puede moverla o quitarla según sea necesario.
            this.llibreTableAdapter1.Fill(this.bibliotecaDataSet.Llibre);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet1.Llibre' Puede moverla o quitarla según sea necesario.
            this.llibreTableAdapter.Fill(this.bibliotecaDataSet1.Llibre);

        }
    }
}
