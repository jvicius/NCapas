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
            _dataService =  AmigoDataService.GetInstance(connectionString);
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

        public string UpdateAmigo(int id, Amigo amigo)
        {
            try
            {
                return _dataService.UpdateAmigo(id,amigo) ? "Amigo Updated Successfully" : "Error Updating Amigo";
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
    }
}