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
using System.Configuration;

namespace EjemploNCapas
{
    public partial class FormAmigo : Form
    {
        private static AmigoService _service;

        public FormAmigo()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new AmigoService(connectionString);
        }
        
        //MOSTRAR AMIGOS
        private void button1_Click(object sender, EventArgs e)
        {
            var list = _service.GetAmigos();
            dataGridView1.DataSource = list;
        }

        //AÑADIR AMIGO
        private void button2_Click(object sender, EventArgs e)
        {
            var amigo = new Amigo();
            amigo.nombre = textBox1.Text;
            amigo.direccion = textBox2.Text;
            amigo.telefono = textBox3.Text;

            try
            {
                amigo.fecnac = dateTimePicker1.Value;
                MessageBox.Show("Añadido correctamente");
            }
            catch
            {
                MessageBox.Show("Datos incompletos");
            }

            var result = _service.AddAmigo(amigo);
            Console.WriteLine(result);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Update();
        }

        //ACTUALIZAR AMIGO
        private void button3_Click(object sender, EventArgs e)
        {
            var amigo = new Amigo();
            var id = 0;
            try
            {
                id = Convert.ToInt32(numericUpDown2.Value);
                MessageBox.Show("Actualizado correctamente");
            }
            catch
            {
                
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
                MessageBox.Show("No se han podido actualizar los datos");
            }

            var result = _service.UpdateAmigo(id, amigo);
            Console.WriteLine(result);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Update();

        }

        //ELIMINAR AMIMGO
        private void button4_Click(object sender, EventArgs e)
        {
            var id = 0;
            try
            {
                id = Convert.ToInt32(numericUpDown1.Value);
                MessageBox.Show("Eliminado correctamente");
            }
            catch
            {
                MessageBox.Show("No se ha podido eliminar Amigo");
            }

            var result = _service.DeleteAmigo(id);
            Console.WriteLine(result);
        }

        //SALIR
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //CLONAR
        private void button6_Click(object sender, EventArgs e)
        {
            var list = _service.GetAmigos();

            foreach(Amigo amigo in list)
            {
                if(amigo.idamigo.ToString() == numericUpDown3.Value.ToString())
                {
                    _service.AddAmigo(amigo.Clonar());
                    MessageBox.Show("Clonado correctamente");

                }
            }
        }
    }
}
