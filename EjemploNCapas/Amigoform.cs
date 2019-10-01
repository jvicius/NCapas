using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinnesLogicLayer.Services;
using DomainLayer.Models;
using System;
using System.Configuration;

namespace EjemploNCapas
{
    public partial class Amigoform : Form
    {
        private static AmigoService _service;

        public Amigoform()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new AmigoService(connectionString);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Ver amigos
        private void button1_Click(object sender, EventArgs e)
        {
            var list = _service.GetAmigos();
            dataGridView1.DataSource = list;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Salir
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Agregar amigo
        private void button2_Click(object sender, EventArgs e)
        {
            var amigo = new Amigo();
            amigo.nombre = textBox1.Text;
            amigo.direccion = textBox2.Text;
            amigo.telefono = textBox3.Text;

            try
            {
                amigo.fecnac = Convert.ToDateTime(dateTimePicker1.Value);
            }
            catch
            {
                // ignored
            }

            var result = _service.AddAmigo(amigo);
    
          
        }
        // Eliminar amigos
        private void button4_Click(object sender, EventArgs e)
        {
           
            
            var id = 0;
            try
            {
                id = Convert.ToInt32(textBox5.Text);
            }
            catch
            {
                // ignored
            }

            var result = _service.DeleteAmigo(id);
           
        }
        // Actualizar amigo
        private void button3_Click(object sender, EventArgs e)
        {
            var amigo = new Amigo();
          
            var id = 0;
            try
            {
                id = Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                // ignored
            }

            amigo.nombre = textBox1.Text;
            amigo.direccion = textBox2.Text;
            amigo.telefono = textBox3.Text;
            try
            {
                amigo.fecnac = Convert.ToDateTime(dateTimePicker1.Value);
            }
            catch
            {
                // ignored
            }

            var result = _service.UpdateAmigo(id, amigo);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var list = _service.GetAmigos();

            foreach(Amigo amigo in list)
            {
                if (amigo.idamigo.ToString() == textBox6.Text)
                    _service.AddAmigo(amigo.Clone());
            }
           

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
