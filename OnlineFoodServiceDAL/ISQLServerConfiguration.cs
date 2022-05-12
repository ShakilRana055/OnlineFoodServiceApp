using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodServiceDAL
{
    public interface ISQLServerConfiguration
    {
        public string GetConnectionString();
        public DataTable ExecuteProcedure(string procedureName);
    }
    public class SQLServerConfiguration : ISQLServerConfiguration
    {
        private readonly IConfiguration configuration;

        public SQLServerConfiguration(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public DataTable ExecuteProcedure(string procedureName)
        {
            using (var sqlConnection = new SqlConnection(this.GetConnectionString()))
            {
                var dataTable = new DataTable(procedureName);
                var sqlCommand = new SqlCommand(procedureName, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                try
                {
                    var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public string GetConnectionString()
        {
            return configuration.GetConnectionString("DefaultConnection");
        }
    }
}
