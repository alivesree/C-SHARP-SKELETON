using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class sampleService
    {
        SampleRepository repo = new SampleRepository();
        public  DataTable getData()
        {
            var data = repo.getDBdata();
            /*
             * 
             * do bll
             * 
             * */
            return data;
        }
    }
}
