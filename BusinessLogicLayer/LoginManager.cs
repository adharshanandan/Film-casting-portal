using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Collections;

namespace BusinessLogicLayer
{

    public class LoginManager
    {
        DbInterfaceHelper Db_obj = new DbInterfaceHelper();

        public SortedList<string, string> GetCredential(string query)
        {
            return Db_obj.ExeReader(query);
        }
       


    }
}
