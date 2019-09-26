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



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Amigo> lista;
        private static AmigoService _service;
        public Form1()
        {
            InitializeComponent();
            var connectionString = "";
            //var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new AmigoService(connectionString);
            lista = _service.GetAmigos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Amigo>);
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            instrucciones.Text = "INGRESE LA INFORMACIÓN PEDIDA:";
            nombrelabel.Visible = true;
            nombretb.Visible = true;
            direccionlabel.Visible = true;
            addresstb.Visible = true;
            telefonolabel.Visible = true;
            phonetb.Visible = true;
            fechalabel.Visible = true;
            birthtb.Visible = true;
            next.Visible = true;
        }

        private void addresstb_TextChanged(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            Amigo amigo = new Amigo();
            amigo.nombre = nombretb.Text;
            amigo.direccion = addresstb.Text;
            amigo.telefono = phonetb.Text;
            try
            {
                amigo.fecnac = Convert.ToDateTime(birthtb.Text);
            }
            catch
            {
                //ignored
            }
            _service.AddAmigo(amigo);
            instrucciones.Text = "AMIGO AGREGADO EXITOSAMENTE";
            nombrelabel.Visible = false;
            nombretb.Visible = false;
            direccionlabel.Visible = false;
            addresstb.Visible = false;
            telefonolabel.Visible = false;
            phonetb.Visible = false;
            fechalabel.Visible = false;
            birthtb.Visible = false;
            next.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            instrucciones.Text = "INGRESE LA INFORMACIÓN PEDIDA:";
            idlabel.Visible = true;
            idtb.Visible = true;
            next2.Visible = true;
        }

        private void next2_Click(object sender, EventArgs e)
        {
            var id = 0;
            try
            {
                id = Convert.ToInt32(idtb.Text);
            }
            catch
            {
                // ignored
            }
            _service.DeleteAmigo(id);
            instrucciones.Text = "AMIGO ELIMINADO EXTIOSAMENTE";
            idlabel.Visible = false;
            idtb.Visible = false;
            next2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            instrucciones.Text = "INGRESE LA INFORMACIÓN PEDIDA:";
            idlabel.Visible = true;
            idtb.Visible = true;
            nombrelabel.Visible = true;
            nombretb.Visible = true;
            direccionlabel.Visible = true;
            addresstb.Visible = true;
            telefonolabel.Visible = true;
            phonetb.Visible = true;
            fechalabel.Visible = true;
            birthtb.Visible = true;
            updateboton.Visible = true;
        }

        private void updateboton_Click(object sender, EventArgs e)
        {
            var id = 0;
            try
            {
                id = Convert.ToInt32(idtb.Text);
            }
            catch
            {
                // ignored
            }
            Amigo amigo = new Amigo();
            amigo.idamigo = id;
            amigo.nombre = nombretb.Text;
            amigo.direccion = addresstb.Text;
            amigo.telefono = phonetb.Text;
            try
            {
                amigo.fecnac = Convert.ToDateTime(birthtb.Text);
            }
            catch
            {
                //ignored
            }
            _service.UpdateAmigo(amigo);
            instrucciones.Text = "AMIGO ACTUALIZADO EXITOSAMENTE";
            idlabel.Visible = false;
            idtb.Visible = false;
            nombrelabel.Visible = false;
            nombretb.Visible = false;
            direccionlabel.Visible = false;
            addresstb.Visible = false;
            telefonolabel.Visible = false;
            phonetb.Visible = false;
            fechalabel.Visible = false;
            birthtb.Visible = false;
            updateboton.Visible = false;
        }
    }
}
