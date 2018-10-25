using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBHelper
    {
        internal DataTable FillDataTable(DBCommand cmd)
        {
            throw new NotImplementedException();
        }
    }
    public class DBCommand : IDisposable
    {
        private NpgsqlCommand _InternalCommand;
        public NpgsqlCommand GetInternalCommand()
        {
            _InternalCommand.CommandType = CommandType.Text;
            _InternalCommand.CommandText = SQLQuery;
            return _InternalCommand;
        }

        public DBCommand()
        {
            _InternalCommand = new NpgsqlCommand();
            Parameters.Clear();
        }
        public DBCommand(string sqlQuery)
        {
            _InternalCommand = new NpgsqlCommand();
            this.SQLQuery = sqlQuery;
            Parameters.Clear();

        }
        public string SQLQuery { get; set; }
        public NpgsqlParameterCollection Parameters
        {
            get
            {
                return _InternalCommand.Parameters;
            }
        }

        public void Dispose()
        {
            SQLQuery = "";
            _InternalCommand.Dispose();
        }
    }

    public class TransactionResult
    {
        public bool IsSucceess { get; set; }
        public string ErrorMessage { get; set; }
        public string Description { get; set; }
        public string ErrorCommandQuery { get; set; }

        public TransactionResult()
        {
            IsSucceess = false;
            ErrorMessage = "";
            Description = "";
            ErrorCommandQuery = "";
        }
    }
}
