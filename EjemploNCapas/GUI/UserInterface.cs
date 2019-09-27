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

namespace EjemploNCapas.GUI
{
    public partial class UserInterface : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();

        public UserInterface()
        {
            InitializeComponent();
            show_Amigo1.Hide();
            addAmigo1.Hide();
            deleteAmigo1.Hide();
            updateamigo1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteAmigo1.Hide();
            show_Amigo1.Hide();
            updateamigo1.Hide();
            addAmigo1.updateAmigo(connectionString);
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            show_Amigo1.Show();
            show_Amigo1.updateTextBox(connectionString);
            deleteAmigo1.Hide();
            addAmigo1.Hide();
            updateamigo1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteAmigo1.expose(connectionString);
            show_Amigo1.Hide();
            addAmigo1.Hide();
            updateamigo1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show_Amigo1.Hide();
            addAmigo1.Hide();
            updateamigo1.update(connectionString);
            deleteAmigo1.Hide();
        }
    }
}
