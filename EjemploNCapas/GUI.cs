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

namespace EjemploNCapas
{
    public partial class GUI : Form
    {
        private AmigoService _service;

        public GUI(AmigoService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            HideAll();
            inicio.Show();
        }

        private void Regresar3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            HideAll();
            inicio.Show();
        }

        private void Regresar1_Click(object sender, EventArgs e)
        {
            HideAll();
            inicio.Show();
        }

        private void Regresar2_Click(object sender, EventArgs e)
        {
            addName.Text = "";
            addAddress.Text = "";
            addPhone.Text = "";
            addBirthDate.Text = "";

            HideAll();
            inicio.Show();
        }

        private void Regresar4_Click(object sender, EventArgs e)
        {
            updateId.Text = "";
            updateName.Text = "";
            updateAddress.Text = "";
            updatePhone.Text = "";
            updateBirthDate.Text = "";

            HideAll();
            inicio.Show();
        }

        private void AddAmigos_Click(object sender, EventArgs e)
        {
            amigos.Show();
            add.Show();
        }

        private void ShowAmigos_Click(object sender, EventArgs e)
        {
            amigos.Show();

            var list = _service.GetAmigos();
            var source = new BindingSource();
            source.DataSource = list;
            dataGridView1.DataSource = source;
        }

        private void DeleteAmigos_Click(object sender, EventArgs e)
        {
            amigos.Show();
            add.Show();
            delete.Show();
        }

        private void UpdateAmigos_Click(object sender, EventArgs e)
        {
            amigos.Show();
            add.Show();
            delete.Show();
            update.Show();
        }

        private void HideAll()
        {
            inicio.Hide();
            amigos.Hide();
            add.Hide();
            delete.Hide();
            update.Hide();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Write an Id.");
                return;
            }

            var id = Convert.ToInt32(textBox1.Text);

            var result = _service.DeleteAmigo(id);
            MessageBox.Show(result);

            textBox1.Text = "";

            HideAll();
            inicio.Show();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (addName.Text == "" | addAddress.Text == "" | addPhone.Text == "" | addBirthDate.Text == "")
            {
                MessageBox.Show("Fill all the fields.");
                return;
            }

            var amigo = new Amigo();
            amigo.nombre = addName.Text;
            amigo.direccion = addAddress.Text;
            amigo.telefono = addPhone.Text;
            try
            {
                amigo.fecnac = Convert.ToDateTime(addBirthDate.Text);
            }
            catch
            {
                // ignored
            }

            var result = _service.AddAmigo(amigo);
            MessageBox.Show(result);

            addName.Text = "";
            addAddress.Text = "";
            addPhone.Text = "";
            addBirthDate.Text = "";

            HideAll();
            inicio.Show();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (updateId.Text == "" |updateName.Text == "" | updateAddress.Text == "" | updatePhone.Text == "" | updateBirthDate.Text == "")
            {
                MessageBox.Show("Fill all the fields.");
                return;
            }

            var amigo = new Amigo();
            amigo.idamigo = Convert.ToInt32(updateId.Text);
            amigo.nombre = updateName.Text;
            amigo.direccion = updateAddress.Text;
            amigo.telefono = updatePhone.Text;
            try
            {
                amigo.fecnac = Convert.ToDateTime(updateBirthDate.Text);
            }
            catch
            {
                // ignored
            }

            var result = _service.UpdateAmigo(amigo);
            MessageBox.Show(result);

            updateId.Text = "";
            updateName.Text = "";
            updateAddress.Text = "";
            updatePhone.Text = "";
            updateBirthDate.Text = "";

            HideAll();
            inicio.Show();
        }
    }
}
