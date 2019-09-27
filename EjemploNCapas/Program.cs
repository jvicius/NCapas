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
            InterfazGrafica Form1 = new InterfazGrafica();
            Form1.ShowDialog();
        }
    }
}
