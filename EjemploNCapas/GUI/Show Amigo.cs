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
using DomainLayer.Models;
using System.Configuration;

namespace EjemploNCapas.GUI
{
    public partial class Show_Amigo : UserControl
    {
        private static AmigoService _service;

        public Show_Amigo()
        {
            InitializeComponent();
        }

        public void updateTextBox(string connectionString)
        {
            _service = new AmigoService(connectionString);
            textBox1.Clear();

            var list = _service.GetAmigos();
            foreach (var item in list)
            {
                textBox1.AppendText($"{item.idamigo}. {item.nombre} | {item.telefono} | {item.direccion} | {item.fecnac} "+"\n");
            }
            
        }
    }
}
