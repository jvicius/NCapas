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
namespace EjemploNCapas.GUI
{
    public partial class updateamigo : UserControl
    {
        private static AmigoService _service;
        private int id;
        private Amigo amigo;
        public updateamigo()
        {
            InitializeComponent();
        }

        public void update(string connectionString)
        {
            this.Show();
            _service = new AmigoService(connectionString);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            amigo=new Amigo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox4.Text);
            amigo.nombre = textBox1.Text;
            amigo.telefono = textBox3.Text;
            amigo.direccion = textBox2.Text;
            amigo.fecnac = Convert.ToDateTime(dateTimePicker1.Value);
            var result = _service.UpdateAmigo(id,amigo);
            MessageBox.Show(result);
        }
    }
}
