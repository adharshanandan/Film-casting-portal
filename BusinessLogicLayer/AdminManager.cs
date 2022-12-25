using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using BusinessLogicLayer.AdminProps;
using System.Collections;

namespace BusinessLogicLayer
{
    public class AdminManager
    {
        public AdminProperty AdmProp_Obj = new AdminProperty();
        private DbInterfaceHelper Db_Obj = new DbInterfaceHelper();
        public FaqProperty FaqProp_Obj = new FaqProperty();
        public ComplaintsProperty ComProp_Obj = new ComplaintsProperty();
        SortedList CommonList = new SortedList();
        public VisitorMessageProperty VisMsgProp_Obj = new VisitorMessageProperty();

        //selects all details from FAQs Table
        public List<FaqProperty> SelectAllData(string proc)
        {
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData(proc);
            List<FaqProperty> FaqList = new List<FaqProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                FaqList.Add(new FaqProperty
                {
                    Id = Convert.ToInt32(dr["QnId"]),
                    Question = dr["Question"].ToString(),
                    Answer = dr["Answer"].ToString()
                });
            }

            return FaqList;

        }

        //selects all details from Complaints Table
        public List<ComplaintsProperty> SelectComplaints(String proc)
        {
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData(proc);
            List<ComplaintsProperty> ComList = new List<ComplaintsProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                ComList.Add(new ComplaintsProperty
                {
                    ComId = Convert.ToInt32(dr["ComId"]),
                    UserId = Convert.ToInt32(dr["UserId"]),
                    Username = dr["Username"].ToString(),
                    Complaints = dr["Complaints"].ToString()
                });
            }

            return ComList;

        }


        public string DeleteFromFaq(string proc)
        {
            CommonList.Clear();
            CommonList.Add("Id", FaqProp_Obj.Id);
            string result = Db_Obj.ExecuteProcedure(proc, CommonList);
            return result;
        }

        public string InsertFaqs(string proc)
        {
            CommonList.Clear();
            CommonList.Add("Question", FaqProp_Obj.Question);
            CommonList.Add("Answer", FaqProp_Obj.Answer);
            string result = Db_Obj.ExecuteProcedure(proc, CommonList);
            return result;
        }

        public List<ActorPropertyforAdmin> SelectActorList(String proc)
        {
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData(proc);
            List<ActorPropertyforAdmin> ActorList = new List<ActorPropertyforAdmin>();
            foreach (DataRow dr in dt.Rows)
            {
                ActorList.Add(new ActorPropertyforAdmin
                {
                    ActorId = Convert.ToInt32(dr["ActorId"]),
                    ActorDob = Convert.ToDateTime(dr["ActorDob"]).ToShortDateString(),
                    ActorName = dr["ActorName"].ToString(),
                    ProPicActor = dr["ProPicActor"].ToString(),
                    ActorGender = dr["ActorGender"].ToString(),
                    ActorEmail = dr["ActorEmail"].ToString(),
                    ActorPh = dr["ActorPh"].ToString(),
                    AccType = dr["AccType"].ToString(),
                    ActorAccStatus = dr["ActorAccStatus"].ToString()
                });
            }

            return ActorList;

        }
        public string AccountStatusChange(string proc, int Id)
        {
            CommonList.Clear();
            CommonList.Add("Id", Id);
            string result = Db_Obj.ExecuteProcedure(proc, CommonList);
            return result;

        }


        public List<DirPropertyforAdmin> SelectDirList(String proc)
        {
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData(proc);
            List<DirPropertyforAdmin> DirList = new List<DirPropertyforAdmin>();
            foreach (DataRow dr in dt.Rows)
            {
                DirList.Add(new DirPropertyforAdmin
                {
                    DirId = Convert.ToInt32(dr["DirId"]),
                    DirName = dr["DirName"].ToString(),
                    DirDob =Convert.ToDateTime(dr["DirDob"]).ToShortDateString(),
                    DirGender = dr["DirGender"].ToString(),
                    ProPicDir = dr["ProPicDir"].ToString(),
                    DirEmail = dr["DirEmail"].ToString(),
                    DirPh = dr["DirPh"].ToString(),
                    DirAccStatus = Convert.ToChar(dr["DirAccStatus"]),

                });
            }

            return DirList;
        }

        public string ValidAdmOrNot()
        {
            CommonList.Clear();
            CommonList.Add("AdminUsername", AdmProp_Obj.AdminUsername);
            return Db_Obj.ExecuteProcedure("IsvalidAdmin", CommonList);
        }

        public List<AdminProperty> DisplayFaqs()
        {
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData("SelectAllFaqs");
            List<AdminProperty> _list = new List<AdminProperty>();
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    _list.Add(new AdminProperty
                    {
                        Question = dr["Question"].ToString(),
                        Answer = dr["Answer"].ToString(),
                        QnId=Convert.ToInt32(dr["QnId"])

                    }); 
                }
            }
            return _list; 
        }
        public List<AdminProperty> DisplayFaqsbySearch()
        {
            CommonList.Clear();
            CommonList.Add("QnKey", AdmProp_Obj.Question);
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData("SelectFaqsbyKeyword", CommonList);
            List<AdminProperty> _list = new List<AdminProperty>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _list.Add(new AdminProperty
                    {
                        Question = dr["Question"].ToString(),
                        Answer = dr["Answer"].ToString(),
                        QnId = Convert.ToInt32(dr["QnId"])

                    });
                }
            }
            return _list;

        }
        public List<VisitorMessageProperty> GetVisitorsMessage()
        {
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData("GetVisitorsMessage");
            List<VisitorMessageProperty> _list = new List<VisitorMessageProperty>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _list.Add(new VisitorMessageProperty
                    {
                        CusId = Convert.ToInt32(dr["CusId"]),
                        CusName = dr["CusName"].ToString(),
                        CusEmail = dr["CusEmail"].ToString(),
                        CusMessage = dr["CusMessage"].ToString()

                    });
                }

            }
            return _list;


        }
        public string DeleteInquiry()
        {
            CommonList.Clear();
            CommonList.Add("CusId", VisMsgProp_Obj.CusId);
            return Db_Obj.ExecuteProcedure("DeleteInquiry", CommonList);
            
        }
    }
}
