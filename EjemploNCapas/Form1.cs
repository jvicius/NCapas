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
            /*Program.ShowAmigos();
            amigos = Program.list;
            dataGridView1.DataSource = new BindingSource(amigos, null);
            dataGridView1.DataSource = typeof(List<Amigo>);
            dataGridView1.DataSource = amigos;*/
            ShowFriends();
        }

        private void ShowFriends()
        {
            Program.ShowAmigos();
            amigos = Program.list;
            dataGridView1.DataSource = new BindingSource(amigos, null);
            dataGridView1.DataSource = typeof(List<Amigo>);
            dataGridView1.DataSource = amigos;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //borrar
            {
                try
                {
                    MessageBox.Show(Program.DeleteFriend(amigos[e.RowIndex].idamigo));
                }
                catch { }
                finally
                {
                    ShowFriends();
                }
            }
            else if (e.ColumnIndex == 1) //editar
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
            else if (e.ColumnIndex == 2) //update
            {
                try
                {
                    Amigo amigo = new Amigo();
                    amigo.nombre = textBoxName.Text;
                    amigo.direccion = textBoxAdress.Text;
                    amigo.telefono = textBoxPhone.Text;
                    amigo.fecnac = dateTimePicker1.Value;

                    var result = Program.ActualizarAmigo(amigos[e.RowIndex].idamigo, amigo);
                    MessageBox.Show(amigo.nombre + amigo.direccion + result + e.RowIndex);
                    ShowFriends();
                    textBoxName.Text = "";
                    textBoxAdress.Text = "";
                    textBoxPhone.Text = "";
                    dateTimePicker1.Value = DateTime.Today;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Amigo amigo = new Amigo();
            amigo.nombre = textBoxName.Text;
            amigo.direccion = textBoxAdress.Text;
            amigo.telefono = textBoxPhone.Text;
            amigo.fecnac = dateTimePicker1.Value;

            var result = Program.AddFriend(amigo);
            MessageBox.Show(result);
            ShowFriends();

        }
    }
}
