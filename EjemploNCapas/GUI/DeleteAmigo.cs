using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinnesLogicLayer.Services;

namespace EjemploNCapas.GUI
{
    public partial class DeleteAmigo : UserControl
    {
        private static AmigoService _service;
        private int id;
        public void expose(string connectionString)
        {
            _service = new AmigoService(connectionString);
            textBox1.Clear();
            this.Show();
        }

        public DeleteAmigo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception exception)
            {
                
            }
            var result = _service.DeleteAmigo(id);
            Console.WriteLine(result);
            MessageBox.Show(result);
        }
    }
}
