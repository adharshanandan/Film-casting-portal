using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Visitor;
using DataAccessLayer;
using System.Collections;

namespace BusinessLogicLayer.Visitor
{
    public class VisitorsManager
    {
        public VisitorsProperty VisProp_Obj = new VisitorsProperty();
        private DbInterfaceHelper Db_obj = new DbInterfaceHelper();
        SortedList S1 = new SortedList();
        public string InstertVisitorsMsg()
        {
            S1.Clear();
            S1.Add("CusName", VisProp_Obj.CusName);
            S1.Add("CusEmail", VisProp_Obj.CusEmail);
            S1.Add("CusMessage", VisProp_Obj.CusMessage);
            return Db_obj.ExecuteProcedure("VisitorsMsgInsert", S1);
        }
        
    }
}
