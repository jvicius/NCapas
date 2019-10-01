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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var list = _service.GetAmigos();
            dataGridView1.DataSource = list;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            
            var id = 0;
            try
            {
                id = Convert.ToInt32(deleteID.Text);
            }
            catch
            {
                // ignored
            }

            var result = _service.DeleteAmigo(id);
            MessageBox.Show(result);
            deleteID.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var amigo = new Amigo();
            //Console.Clear();
            //Console.WriteLine("New Amigos");
            //Console.WriteLine("Name: ");
            amigo.nombre = addName.Text;
            //Console.WriteLine("Address: ");
            amigo.direccion = addAddress.Text;
            //Console.WriteLine("PhoneNumber: ");
            amigo.telefono = addNum.Text;
            //Console.WriteLine("BirthDate: ");
            try
            {
                amigo.fecnac = Convert.ToDateTime(addBirth.Text);
            }
            catch
            {
                MessageBox.Show("Error en datos.");
            }

            var result = _service.AddAmigo(amigo);
            //Console.WriteLine(result);
            //Console.WriteLine("Press ESC to continue...");
            //while (Console.ReadKey().Key != ConsoleKey.Escape)
            //{
            //}
            addName.Text = "";
            addAddress.Text = "";
            addNum.Text = "";
            addBirth.Text = "";

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var amigo = new Amigo();
            //Console.Clear();
            //Console.WriteLine("Update Amigos");

            //Console.WriteLine("IdAmigo: ");
            var id = 0;
            try
            {
                id = Convert.ToInt32(modID.Text);
            }
            catch
            {
                // ignored
            }

            //Console.WriteLine("Name: ");
            amigo.nombre = modName.Text;
            //Console.WriteLine("Address: ");
            amigo.direccion = modAddress.Text;
            //Console.WriteLine("PhoneNumber: ");
            amigo.telefono = modNum.Text;
            //Console.WriteLine("BirthDate: ");
            try
            {
                amigo.fecnac = Convert.ToDateTime(modBirth.Text);
            }
            catch
            {
                // ignored
            }

            var result = _service.UpdateAmigo(id, amigo);
            //Console.WriteLine(result);
            //Console.WriteLine("Press ESC to continue...");
            //while (Console.ReadKey().Key != ConsoleKey.Escape)
            //{
            //}
            modName.Text = "";
            modAddress.Text = "";
            modNum.Text = "";
            modBirth.Text = "";
            modID.Text = "";
        }

        private void CloneB_Click(object sender, EventArgs e)
        {
            var list = _service.GetAmigos();

            foreach(Amigo amigo in list)
            {
                if (amigo.idamigo.ToString() == idClone.Text)
                    _service.AddAmigo(amigo.Clone());
            }
        }
    }
}
