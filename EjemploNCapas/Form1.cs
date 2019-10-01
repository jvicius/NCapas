using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploNCapas
{
    public partial class Form1 : Form
    {
        List<Amigo> amigos;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ShowAmigos();
            amigos = Program.list;
            dataGridView1.DataSource = new BindingSource(amigos, null);
            dataGridView1.DataSource = typeof(List<Amigo>);
            dataGridView1.DataSource = amigos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*textBoxName.Text = "";
            textBoxAdress.Text = "";
            textBoxPhone.Text = "";
            dateTimePicker1.Value = DateTime.Today;*/
            //e.ColumnIndex  == 0 borrar
            //1 editar
            //2 update
            if (e.ColumnIndex == 0)
            {

            }
            else if (e.ColumnIndex == 1)
            {
                try
                {
                    textBoxName.Text = amigos[e.RowIndex].nombre;
                    textBoxAdress.Text = amigos[e.RowIndex].direccion;
                    textBoxPhone.Text = amigos[e.RowIndex].telefono;
                    dateTimePicker1.Value = amigos[e.RowIndex].fecnac;
                }
                catch { }
            }
            else if (e.ColumnIndex == 2)
            {
                try
                {
                    Amigo amigo = new Amigo();
                    amigo.nombre = textBoxName.Text;
                    amigo.direccion = textBoxAdress.Text;
                    amigo.telefono = textBoxPhone.Text;
                    amigo.fecnac = dateTimePicker1.Value;

                    var result = Program.ActualizarAmigo(e.RowIndex, amigo);
                    MessageBox.Show(amigo.nombre + amigo.direccion + result + e.RowIndex);
                    dataGridView1.DataSource = new BindingSource(amigos, null);
                    dataGridView1.DataSource = typeof(List<Amigo>);
                    dataGridView1.DataSource = amigos;
                }
                catch { }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
