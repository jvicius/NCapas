﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DomainLayer.Models;

namespace DataAccessLayer
{
    class AmigoDataServiceSingleton
    {
        private readonly SqlClient _client;

        private AmigoDataServiceSingleton(string connectionString)
        {
            _client = new SqlClient(connectionString);
        }
        private static AmigoDataServiceSingleton _instance;

        public static AmigoDataServiceSingleton GetInstance(string connectionString)
        {
            if (_instance == null)
            {
                _instance = new AmigoDataServiceSingleton(connectionString);
            }
            return _instance;
        }

        public List<Amigo> GetAmigos()
        {
            var result = new List<Amigo>();
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Conecction,
                        CommandText = "getamigos",
                        CommandType = CommandType.StoredProcedure
                    };
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var amigo = new Amigo
                        {
                            idamigo = Convert.ToInt32(dataReader["idamigo"].ToString()),
                            nombre = dataReader["nombre"].ToString(),
                            fecnac = Convert.ToDateTime(dataReader["fecnac"].ToString()),
                            direccion = dataReader["direccion"].ToString(),
                            telefono = dataReader["telefono"].ToString()
                        };
                        result.Add(amigo);
                    }
                }
            }
            catch
            {
                // ignored
            }
            finally
            {
                _client.Close();
            }

            return result;
        }

        public bool AddAmigo(Amigo amigo)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Conecction,
                        CommandText = "addamigo",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@nombre", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = amigo.nombre
                    };

                    var par2 = new SqlParameter("@fecnac", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        Value = amigo.fecnac
                    };

                    var par3 = new SqlParameter("@direccion", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = amigo.direccion
                    };

                    var par4 = new SqlParameter("@telefono", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = amigo.telefono
                    };

                    var par5 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par4);
                    command.Parameters.Add(par5);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }

        public bool DeleteAmigo(int idamigo)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Conecction,
                        CommandText = "deleteamigo",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@idamigo", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = idamigo
                    };

                    var par5 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par5);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }

        //******************UPDATE************************
        public bool updateamigo(int idamigo, Amigo amigo)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Conecction,
                        CommandText = "updateamigo",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@idamigo", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = idamigo
                    };

                    var par5 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    var par2 = new SqlParameter("@fecnac", SqlDbType.Date)
                    {
                        Direction = ParameterDirection.Input,
                        Value = amigo.fecnac
                    };
                    var par3 = new SqlParameter("@direccion", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = amigo.direccion
                    };
                    var par4 = new SqlParameter("@telefono", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = amigo.telefono
                    };
                    var par6 = new SqlParameter("@nameamigo", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = amigo.nombre
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par5);
                    command.Parameters.Add(par6);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par4);


                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception e)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }
    }
}
