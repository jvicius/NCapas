using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinnesLogicLayer.Services;
using DomainLayer.Models;
using System.Windows.Forms;

namespace EjemploNCapas.GUI
{

    public partial class AddAmigo : UserControl
    {
        Amigo amigo;
        private static AmigoService _service;
        public AddAmigo()
        {
            InitializeComponent();
        }

        public void updateAmigo(string connectionString)
        {
            amigo=new Amigo();
            _service = new AmigoService(connectionString);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            amigo.nombre = textBox1.Text;
            amigo.telefono = textBox3.Text;
            amigo.direccion = textBox2.Text;
            amigo.fecnac = Convert.ToDateTime(dateTimePicker1.Value);
            var result = _service.AddAmigo(amigo);
            MessageBox.Show(result);


        }
    }
}
