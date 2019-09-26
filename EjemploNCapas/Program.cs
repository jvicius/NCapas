using BusinnesLogicLayer.Services;
using DomainLayer.Models;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace EjemploNCapas
{
    internal class Program
    {
        private static AmigoService _service;

        private static void Main()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new AmigoService(connectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI(_service));
        }
    }
}
