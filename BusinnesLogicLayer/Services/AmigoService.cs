using System;
using DataAccessLayer;
using DomainLayer.Models;
using System.Collections.Generic;

namespace BusinnesLogicLayer.Services
{
    public class AmigoService
    {
        //private readonly AmigoDataService _dataService;
        private static AmigoDataService _dataService;
        private static AmigoService _amigoService;

        private AmigoService(string connectionString)
        {
            //_dataService = new AmigoDataService(connectionString);
            _dataService = AmigoDataService.GetAmigoDataService(connectionString);
        }

        public static AmigoService GetAmigoService(string connectionString)
        {
            if(_amigoService == null)
            {
                _amigoService = new AmigoService(connectionString);
            }
            return _amigoService;
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

        public string UpdateAmigo(int idamigo, Amigo amigo)
        {
            try
            {
                return _dataService.UpdateAmigo(idamigo,amigo) ? "Amigo Updated Successfully" : "Error in update Amigo";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}