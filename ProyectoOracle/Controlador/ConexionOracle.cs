using Oracle.ManagedDataAccess.Client;
using System;
//using Dapper;
//using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data;

namespace ProyectoOracle.Controlador
{
    public class ConexionOracle
    {
        private const String SOURCE = "LOCALHOST:1521";
        private static String USER = "proyecto_oracle";
        private static String PASSWD = "oracle123";
        private static String strConexion = "DATA SOURCE=" + SOURCE + ";USER ID=" + USER + ";PASSWORD=" + PASSWD + ";";
        private static OracleConnection con = new OracleConnection(strConexion);
        private static ConexionOracle _instance = new ConexionOracle();
        private ConexionOracle()
        {
            con.Open();
        }
        public static ConexionOracle Conexion
        {
            get {
                if (_instance != null)
                {
                    return _instance;
                }
                else
                {
                    return _instance = new ConexionOracle();
                }
            }
        }
        public List<T> GetAll<T>() where T : class, new()
        {
            CommandManager cmd = new CommandManager(con);
            return cmd.GetAll<T>();
        }
        public T Get<T>(dynamic id) where T : class, new()
        {
            CommandManager cmd = new CommandManager(con);
            return cmd.Get<T>(id);
        }
        public bool Insert<T>(T objeto,bool autoId = true) where T : class, new()
        {
            try
            {
                CommandManager cmd = new CommandManager(con);
                return cmd.Insert(objeto,autoId);
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool Update<T>(T objeto) where T : class, new()
        {
            CommandManager cmd = new CommandManager(con);
            return cmd.Update(objeto);
        }
        public bool Delete<T>(T objeto) where T : class, new()
        {
            CommandManager cmd = new CommandManager(con);
            return cmd.Delete(objeto);
        }
    }
}
