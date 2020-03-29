﻿using System;
using System.Configuration;
using System.Data.SqlClient;

namespace MentoringA1_EF_DBfirst_Ramanau
{
    public class ConnectionContext : IDisposable
    {
        private readonly SqlConnection connection;
        private readonly ConnectionStringSettings connectionString;
        private bool disposed = false;

        public ConnectionContext()
        {
            connectionString = ConfigurationManager.ConnectionStrings["NorthwindConnection"];
            connection = new SqlConnection(connectionString.ConnectionString);
        }

        public SqlCommand CreateCommand()
        {
            return connection.CreateCommand();
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    connection.Close();
                }
                disposed = true;
            }
        }
        ~ConnectionContext()
        {
            Dispose(false);
        }
    }
}
