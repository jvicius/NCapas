using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinnesLogicLayer.Services;
using DomainLayer.Models;
using System.Configuration;

namespace EjemploNCapas.GUI
{
    public partial class Show_Amigo : UserControl
    {
        private static AmigoService _service;
        private List<Amigo> list;
        private string cS;
        public Show_Amigo()
        {
            InitializeComponent();
        }

        private void setHeaders()
        {
            dataGridView1.Columns[0].HeaderText="ID";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Fecha Nacimiento";
            dataGridView1.Columns[3].HeaderText = "Direccion";
            dataGridView1.Columns[4].HeaderText = "Telefono";
            dataGridView1.Columns[5].HeaderText = "Clonar";

        }

        public void updateTextBox(string connectionString)
        {
            cS = connectionString;
            _service = new AmigoService(cS);
            
             list = _service.GetAmigos();
            var source=new BindingSource(list, null);
            dataGridView1.DataSource = source;
            setHeaders();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _service = new AmigoService(cS);

            _service.AddAmigo(list[e.RowIndex].Clone() );
            list = _service.GetAmigos();
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
            setHeaders();
        }
    }
}
