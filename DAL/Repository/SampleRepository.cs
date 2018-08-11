using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
   public class SampleRepository
    {
        DBHelper DB = new DBHelper();
        public DataTable getDBdata()
        {
            DBCommand cmd = new DBCommand("select * from table1");
            DataTable data = DB.FillDataTable(cmd);
            return data;
        }
    }
}
