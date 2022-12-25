using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Director.DirectorProperty;
using DataAccessLayer;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer.Actor.ActorPropery;

namespace BusinessLogicLayer.Director.DirectorManager
{
    public class DirManager
    {
        public DirProperty DirProp_Obj = new DirProperty();
        private DbInterfaceHelper Db_Obj = new DbInterfaceHelper();
        SortedList S1 = new SortedList();
        public ComplaintsProperty ComPropObj = new ComplaintsProperty();
        public ActorRegistrationProperty RegProp_Obj = new ActorRegistrationProperty();
        public string InsertDirData()
        {
            S1.Clear();
            S1.Add("Dirname", DirProp_Obj.DirName);
            S1.Add("DirAddress", DirProp_Obj.DirAddress);
            S1.Add("DirGender", DirProp_Obj.DirGender);
            S1.Add("DirDob", DirProp_Obj.DirDob);
            S1.Add("DirCountry", DirProp_Obj.DirCountry);
            S1.Add("DirState", DirProp_Obj.DirState);
            S1.Add("DirDist", DirProp_Obj.DirDist);
            S1.Add("MembId", DirProp_Obj.MembId);
            S1.Add("ProPicDir", DirProp_Obj.ProPicDir);
            S1.Add("FilmIndustry", DirProp_Obj.FilmIndustry);
            S1.Add("DirEmail", DirProp_Obj.DirEmail);
            S1.Add("DirPassword", DirProp_Obj.DirPassword);
            S1.Add("DirPh", DirProp_Obj.DirPh);

            return Db_Obj.ExecuteProcedure("DirectorDetailsInsert", S1);
        }
        public string ValidDirOrNot()
        {
            S1.Clear();
            S1.Add("DirEmail", DirProp_Obj.DirEmail);
            return Db_Obj.ExecuteProcedure("IsvalidDir", S1);
        }

        public void SelectDirDetails(string proc)
        {
            DataTable dt = new DataTable();
            S1.Clear();
            S1.Add("DirEmail", DirProp_Obj.DirEmail);
            dt = Db_Obj.GetTableData(proc, S1);
            if (dt.Rows.Count > 0)
            {
                DirProp_Obj.DirId = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                DirProp_Obj.DirName = dt.Rows[0].ItemArray[1].ToString();
                DirProp_Obj.DirAddress = dt.Rows[0].ItemArray[2].ToString();
                DirProp_Obj.DirGender = dt.Rows[0].ItemArray[3].ToString();
                DirProp_Obj.DirDob = Convert.ToDateTime(dt.Rows[0].ItemArray[4]);
                DirProp_Obj.DirCountry = dt.Rows[0].ItemArray[5].ToString();
                DirProp_Obj.DirState = dt.Rows[0].ItemArray[6].ToString();
                DirProp_Obj.DirDist = dt.Rows[0].ItemArray[7].ToString();
                DirProp_Obj.MembId = dt.Rows[0].ItemArray[8].ToString();
                DirProp_Obj.ProPicDir = dt.Rows[0].ItemArray[9].ToString();
                DirProp_Obj.FilmIndustry = dt.Rows[0].ItemArray[10].ToString();
                DirProp_Obj.DirPh = dt.Rows[0].ItemArray[11].ToString();
                DirProp_Obj.DirAccStatus = Convert.ToChar(dt.Rows[0].ItemArray[12]);



            }

        }

        public string UserPropic()
        {
            S1.Clear();
            S1.Add("DirEmail", DirProp_Obj.DirEmail);

            return Db_Obj.ExecuteProcedure("SelectProPicDir", S1);
        }
        public string UpdateDirData()
        {
            S1.Clear();
            S1.Add("DirName", DirProp_Obj.DirName);
            S1.Add("DirAddress", DirProp_Obj.DirAddress);
            S1.Add("DirGender", DirProp_Obj.DirGender);
            S1.Add("DirDob", DirProp_Obj.DirDob);
            S1.Add("DirCountry", DirProp_Obj.DirCountry);
            S1.Add("DirDist", DirProp_Obj.DirDist);
            S1.Add("DirState", DirProp_Obj.DirState);
            S1.Add("MembId", DirProp_Obj.MembId);
            S1.Add("ProPicDir", DirProp_Obj.ProPicDir);
            S1.Add("FilmIndustry", DirProp_Obj.FilmIndustry);
            S1.Add("DirPh", DirProp_Obj.DirPh);
            S1.Add("DirEmail", DirProp_Obj.DirEmail);
            return Db_Obj.ExecuteProcedure("DirDetailsUpdate", S1);
        }



        public List<DirProperty> SelectDirDetailsToHome()
        {
            S1.Clear();
            S1.Add("ActorEmail", DirProp_Obj.DirEmail);
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData("NotFollowingDiretors",S1);
            List<DirProperty> _list = new List<DirProperty>();
            foreach (DataRow dr in dt.Rows)
            {

                _list.Add(new DirProperty
                {
                    DirName = dr["DirName"].ToString(),
                    ProPicDir = dr["ProPicDir"].ToString(),
                    DirId = Convert.ToInt32(dr["DirId"])



                });


            }
            return _list;

        }

        public List<DirProperty> SelectDirbySearch(string proc, string KeySearch)
        {
            DataTable dt = new DataTable();
            S1.Clear();
            S1.Add("KeySearch", KeySearch);
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            dt = Db_Obj.GetTableData(proc, S1);
            List<DirProperty> _list = new List<DirProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new DirProperty
                {
                    DirName = dr["DirName"].ToString(),
                    ProPicDir = dr["ProPicDir"].ToString(),
                    DirId = Convert.ToInt32(dr["DirId"])



                });


            }
            return _list;

        }

        public string InsertComplaint()
        {
            S1.Clear();
            S1.Add("DirEmail", DirProp_Obj.DirEmail);
            S1.Add("Complaints", ComPropObj.Complaints);
            return Db_Obj.ExecuteProcedure("ComplaintsInsertDir", S1);
        }


        public List<DirProperty> SelectActorFollowings()
        {
            S1.Clear();
            S1.Add("ActorEmail", DirProp_Obj.DirEmail);
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData("ActorFollowings", S1);
            List<DirProperty> _list = new List<DirProperty>();
            foreach (DataRow dr in dt.Rows)
            {

                _list.Add(new DirProperty
                {
                    DirEmail=dr["DirEmail"].ToString(),
                    DirName = dr["DirName"].ToString(),
                    ProPicDir = dr["ProPicDir"].ToString(),
                    DirId = Convert.ToInt32(dr["DirId"])



                });


            }
            return _list;



        }

        public Array GetCastIdsByDir(string EmailId)
        {

            S1.Clear();
            S1.Add("DirEmail", EmailId);
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData("GetCastIdsByDir", S1);
            int[] CastArr = new int[dt.Rows.Count];
            if (dt.Rows.Count > 0)
            {
               
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    CastArr[i] = Convert.ToInt32(dt.Rows[i].ItemArray[0].ToString());
                    
                    i++;
                }

            }
            return CastArr;


        }

    }
}
