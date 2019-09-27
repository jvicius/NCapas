using System;
using DataAccessLayer;
using DomainLayer.Models;
using System.Collections.Generic;

namespace BusinnesLogicLayer.Services
{
    public class AmigoService
    {
        private readonly AmigoDataService _dataService;

        public AmigoService(string connectionString)
        {
            _dataService = new AmigoDataService(connectionString);
        }

        public List<Amigo> GetAmigos()
        {
            return _dataService.GetAmigos();
        }

        public string AddAmigo(Amigo amigo)
        {
            try
            {
                return _dataService.AddAmigo(amigo) ? "Amigo Add Successfully" : "Error Adding Amigo";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string DeleteAmigo(int idamigo)
        {
            try
            {
                return _dataService.DeleteAmigo(idamigo) ? "Amigo Delete Successfully" : "Error in delete Amigo";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //updateamigo
        public string updateamigo(int idamigo, Amigo amigo)
        {
            try
            {
                return _dataService.updateamigo(idamigo, amigo) ? "Amigo update Successfully" : "Error in update Amigo";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}