using BusinnesLogicLayer.Services;
using DomainLayer.Models;
using System;
using System.Configuration;

namespace EjemploNCapas
{
    internal class Program
    {
        private static AmigoService _service;

        private static void Main()
        {
            Amigoform vista = new Amigoform();
            vista.ShowDialog();
            //var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            //_service = new AmigoService(connectionString);
            //var key = new ConsoleKeyInfo();

            //while (!(key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.NumPad5))
            //{
            //    key = ShowMenu();

            //    switch (key.Key)
            //    {
            //        case ConsoleKey.D1:
            //        case ConsoleKey.NumPad1:
            //            ShowAmigos();
            //            break;
            //        case ConsoleKey.D2:
            //        case ConsoleKey.NumPad2:
            //            AddAmigo();
            //            break;
            //        case ConsoleKey.D3:
            //        case ConsoleKey.NumPad3:
            //            DeleteAmigo();
            //            break;
            //        case ConsoleKey.D4:
            //        case ConsoleKey.NumPad4:
            //            UpdateAmigo();
            //            break;

            //    }
            }
        }

    //    private static void ShowAmigos(bool wait = true)
    //    {
    //        if (wait)
    //        {
    //            Console.Clear();
    //        }

    //        var list = _service.GetAmigos();
    //        foreach (var item in list)
    //        {
    //            Console.WriteLine($"{item.idamigo}. {item.nombre} | {item.telefono} | {item.direccion} | {item.fecnac} ");
    //        }

    //        if (wait)
    //        {
    //            Console.WriteLine("Press ESC to continue...");
    //            while (Console.ReadKey().Key != ConsoleKey.Escape)
    //            {
    //            }
    //        }
    //    }

    //    private static void AddAmigo()
    //    {
    //        var amigo = new Amigo();
    //        Console.Clear();
    //        Console.WriteLine("New Amigos");
    //        Console.WriteLine("Name: ");
    //        amigo.nombre = Console.ReadLine();
    //        Console.WriteLine("Address: ");
    //        amigo.direccion = Console.ReadLine();
    //        Console.WriteLine("PhoneNumber: ");
    //        amigo.telefono = Console.ReadLine();
    //        Console.WriteLine("BirthDate: ");
    //        try
    //        {
    //            amigo.fecnac = Convert.ToDateTime(Console.ReadLine());
    //        }
    //        catch
    //        {
    //            // ignored
    //        }

    //        var result = _service.AddAmigo(amigo);
    //        Console.WriteLine(result);
    //        Console.WriteLine("Press ESC to continue...");
    //        while (Console.ReadKey().Key != ConsoleKey.Escape)
    //        {
    //        }
    //    }

    //    private static void DeleteAmigo()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Delete Amigos");
    //        ShowAmigos(false);
    //        Console.WriteLine("Enter Id to delete:");
    //        var id = 0;
    //        try
    //        {
    //            id = Convert.ToInt32(Console.ReadLine());
    //        }
    //        catch
    //        {
    //            // ignored
    //        }

    //        var result = _service.DeleteAmigo(id);
    //        Console.WriteLine(result);
    //        Console.WriteLine("Press ESC to continue...");
    //        while (Console.ReadKey().Key != ConsoleKey.Escape)
    //        {
    //        }
    //    }


    //    private static void UpdateAmigo()
    //    {
    //        var amigo = new Amigo();
    //        Console.Clear();
    //        Console.WriteLine("Update Amigos");

    //        Console.WriteLine("IdAmigo: ");
    //        var id = 0;
    //        try
    //        {
    //            id = Convert.ToInt32(Console.ReadLine());
    //        }
    //        catch
    //        {
    //            // ignored
    //        }

    //        Console.WriteLine("Name: ");
    //        amigo.nombre = Console.ReadLine();
    //        Console.WriteLine("Address: ");
    //        amigo.direccion = Console.ReadLine();
    //        Console.WriteLine("PhoneNumber: ");
    //        amigo.telefono = Console.ReadLine();
    //        Console.WriteLine("BirthDate: ");
    //        try
    //        {
    //            amigo.fecnac = Convert.ToDateTime(Console.ReadLine());
    //        }
    //        catch
    //        {
    //            // ignored
    //        }

    //        var result = _service.UpdateAmigo(id, amigo);
    //        Console.WriteLine(result);
    //        Console.WriteLine("Press ESC to continue...");
    //        while (Console.ReadKey().Key != ConsoleKey.Escape)
    //        {
    //        }
    //    }

    //    private static ConsoleKeyInfo ShowMenu()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("1. Show Amigos");
    //        Console.WriteLine("2. Add Amigos");
    //        Console.WriteLine("3. Delete Amigos");
    //        Console.WriteLine("4. Update Amigos");
    //        Console.WriteLine("5. Exit");
    //        return Console.ReadKey();
    //    }
    //}
}
