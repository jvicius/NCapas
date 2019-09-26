using BusinnesLogicLayer.Services;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private static AmigoService _service;
        public Form1()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new AmigoService(connectionString);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var list = _service.GetAmigos();

            dataGridView1.DataSource = list;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var amigo = new Amigo();
            amigo.nombre = textBox1.Text;
            amigo.direccion = textBox2.Text;
            amigo.telefono = textBox3.Text;
            try
            {
                amigo.fecnac = Convert.ToDateTime(textBox4.Text);
            }
            catch
            {
                // ignored
            }

            var result = _service.AddAmigo(amigo);
            MessageBox.Show(result);
        }

        private void Button3_Click(object sender, EventArgs e)
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
            MessageBox.Show(result);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var amigo = new Amigo();
            var id = 0;
            try
            {
                id = Convert.ToInt32(textBox10.Text);
            }
            catch
            {
                // ignored
            }

            amigo.nombre = textBox9.Text;
            amigo.direccion = textBox8.Text;
            amigo.telefono = textBox7.Text;
            try
            {
                amigo.fecnac = Convert.ToDateTime(textBox6.Text);
            }
            catch
            {
                // ignored
            }

            var result = _service.UpdateAmigo(id, amigo);
            MessageBox.Show(result);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
