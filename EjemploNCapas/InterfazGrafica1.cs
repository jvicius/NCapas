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
    public partial class InterfazGrafica : Form
    {
        private static AmigoService _service;

        public InterfazGrafica()
        {
            
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new AmigoService(connectionString);
            var key = new ConsoleKeyInfo();
            InitializeComponent();
        }


        private void BShow_Click(object sender, EventArgs e)
        {
            ShowAmigos();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            AddAmigo();
        }

        private void Bdelete_Click(object sender, EventArgs e)
        {
            DeleteAmigo();
        }

        private void Bupdate_Click(object sender, EventArgs e)
        {
            Baccept.Visible = false;
            Lname.Visible = true;
            Laddress.Visible = true;
            LPNum.Visible = true;
            LBD.Visible = true;
            TName.Visible = true;
            TAddress.Visible = true;
            TPN.Visible = true;
            TBD.Visible = true;
            dataGridView1.Visible = false;

            TID.Visible = true;
            LID.Visible = true;
            BAcceptID.Visible = false;

            BAcceptUpdate.Visible = true;
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ShowAmigos(bool wait = true)
        {
            Baccept.Visible = false;
            Lname.Visible = false;
            Laddress.Visible = false;
            LPNum.Visible = false;
            LBD.Visible = false;
            TName.Visible = false;
            TAddress.Visible = false;
            TPN.Visible = false;
            TBD.Visible = false;
            TID.Visible = false;
            LID.Visible = false;
            BAcceptID.Visible = false;
            BAcceptUpdate.Visible = false;

            dataGridView1.Visible = true;


            var list = _service.GetAmigos();
            dataGridView1.DataSource = list;
            

        }

        private void AddAmigo()
        {
            TID.Visible = false;
            LID.Visible = false;
            BAcceptID.Visible = false;
            BAcceptUpdate.Visible = false;

            Baccept.Visible = true;
            Lname.Visible = true;
            Laddress.Visible = true;
            LPNum.Visible = true;
            LBD.Visible = true;
            TName.Visible = true;
            TAddress.Visible = true;
            TPN.Visible = true;
            TBD.Visible = true;

            dataGridView1.Visible = false;
        }

        private void DeleteAmigo()
        {
            Baccept.Visible = false;
            Lname.Visible = false;
            Laddress.Visible = false;
            LPNum.Visible = false;
            LBD.Visible = false;
            TName.Visible = false;
            TAddress.Visible = false;
            TPN.Visible = false;
            TBD.Visible = false;
            BAcceptUpdate.Visible = false;

            dataGridView1.Visible = false;

            TID.Visible = true;
            LID.Visible = true;
            BAcceptID.Visible = true;

            // ShowAmigos(false);

        }

        private void Baccept_Click(object sender, EventArgs e)
        {
            var amigo = new Amigo();
            amigo.nombre = TName.Text;
            amigo.direccion = TAddress.Text;
            amigo.telefono = TPN.Text;
            try
            {
                amigo.fecnac = Convert.ToDateTime(TBD.Text);
            }
            catch
            {
                MessageBox.Show("Error en datos");
            }

            var result = _service.AddAmigo(amigo);
            TName.Text = "";
            TAddress.Text = "";
            TPN.Text = "";
            TBD.Text = "";
        }

        private void BAcceptID_Click(object sender, EventArgs e)
        {
            var id = 0;
            try
            {
                id = Convert.ToInt32(TID.Text);
                TID.Text="";
                MessageBox.Show("ID Deleted");
            }
            catch
            {
                // ignored
            }

            var result = _service.DeleteAmigo(id);
        }

        private void BAcceptUpdate_Click(object sender, EventArgs e)
        {
            var id = 0;
            var amigo = new Amigo();
            amigo.nombre = TName.Text;
            amigo.direccion = TAddress.Text;
            amigo.telefono = TPN.Text;
            try
            {
                id = Convert.ToInt32(TID.Text);
                amigo.fecnac = Convert.ToDateTime(TBD.Text);
                TID.Text = "";
                MessageBox.Show("ID Updated");
            }
            catch
            {
                MessageBox.Show("Error en datos");
            }


            var result = _service.updateamigo(id, amigo);
            TName.Text = "";
            TAddress.Text = "";
            TPN.Text = "";
            TBD.Text = "";
        }
    }
}
