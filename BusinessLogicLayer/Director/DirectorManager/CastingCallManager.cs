using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLogicLayer.Director.DirectorProperty;
using System.Collections;
using System.Data;
using BusinessLogicLayer.Actor.ActorPropery;

namespace BusinessLogicLayer.Director.DirectorManager
{
    public class CastingCallManager
    {
        public CastingCallProperty CastProp_Obj = new CastingCallProperty();
        private DbInterfaceHelper Db_Obj = new DbInterfaceHelper();
        SortedList S1 = new SortedList();
        public ActorRegistrationProperty RegProp_Obj = new ActorRegistrationProperty();

        public string CastingCallInsert()
        {
            S1.Clear();
            S1.Add("DirEmail", CastProp_Obj.DirEmail);
            CastProp_Obj.DirectorId =Convert.ToInt32(Db_Obj.ExecuteProcedure("GetDirectorId", S1));
            S1.Clear();
            S1.Add("DirectorId", CastProp_Obj.DirectorId);
            S1.Add("PreGender", CastProp_Obj.PreGender);
            S1.Add("AgeFrom", CastProp_Obj.AgeFrom);
            S1.Add("AgeTo", CastProp_Obj.AgeTo);
            S1.Add("PreExperience", CastProp_Obj.PreExperience);
            S1.Add("PreCountry", CastProp_Obj.PreCountry);
            S1.Add("PreState", CastProp_Obj.PreState);
            S1.Add("PreDist", CastProp_Obj.PreDist);
            S1.Add("PreSkinCol", CastProp_Obj.PreSkinCol);
            S1.Add("PreHairCol", CastProp_Obj.PreHairCol);
            S1.Add("PreEyeCol", CastProp_Obj.PreEyeCol);
            S1.Add("PreBodyStruct", CastProp_Obj.PreBodyStruct);
            S1.Add("PreHeight", CastProp_Obj.PreHeight);
            S1.Add("CharacterDiscription", CastProp_Obj.CharacterDiscription);
            S1.Add("NoOfActors", CastProp_Obj.NoOfActors);
            S1.Add("ProductionName", CastProp_Obj.ProductionName);
            S1.Add("PostedDate", Convert.ToDateTime(CastProp_Obj.PostedDate));
            S1.Add("LastDate", Convert.ToDateTime(CastProp_Obj.LastDate));
            S1.Add("MovieName", CastProp_Obj.MovieName);
            S1.Add("MovieLanguage", CastProp_Obj.MovieLanguage);
            return Db_Obj.ExecuteProcedure("CastingCallInsert", S1);
        }

        public List<CastingCallProperty> GetCallDetails(string proc)
        {
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail.ToString());
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData(proc,S1);
            int Count = 0;
            List<CastingCallProperty> _list = new List<CastingCallProperty>();
            foreach(DataRow dr in dt.Rows)
            {
                Count++;

                _list.Add(new CastingCallProperty
                {
                    CastId = Convert.ToInt32(dr["CastId"]),
                    
                    MovieLanguage = dr["MovieLanguage"].ToString(),
                    MovieName = dr["MovieName"].ToString(),
                    ProductionName = dr["ProductionName"].ToString(),
                    PreExperience = dr["PreExperience"].ToString(),
                    CharacterDiscription = dr["CharacterDiscription"].ToString(),
                    AgeFrom = Convert.ToInt32(dr["AgeFrom"]),
                    AgeTo = Convert.ToInt32(dr["AgeTo"]),
                    PostedDate = Convert.ToDateTime(dr["PostedDate"]).ToShortDateString(),
                    FilmIcon = "~/ActorPages/Film-icon.png",
                    LastDate = Convert.ToDateTime(dr["LastDate"]).ToShortDateString(),
                    PreGender = dr["PreGender"].ToString()


                }) ; 
                
            }
            CastProp_Obj.Count = Count;
            return _list;
        }

        public void GetCastDetailsbyId()
        {
            DataTable dt = new DataTable();
            S1.Clear();
            S1.Add("CastId", CastProp_Obj.CastId);
            dt = Db_Obj.GetTableData("SelectCastingCall", S1);
            if (dt.Rows.Count > 0)
            {
                CastProp_Obj.PreGender = dt.Rows[0].ItemArray[0].ToString();
                CastProp_Obj.AgeFrom = Convert.ToInt32(dt.Rows[0].ItemArray[1]);
                CastProp_Obj.AgeTo= Convert.ToInt32(dt.Rows[0].ItemArray[2]);
                CastProp_Obj.PreExperience= dt.Rows[0].ItemArray[3].ToString();
                CastProp_Obj.PreCountry= dt.Rows[0].ItemArray[4].ToString();
                CastProp_Obj.PreState= dt.Rows[0].ItemArray[5].ToString();
                CastProp_Obj.PreDist= dt.Rows[0].ItemArray[6].ToString();
                CastProp_Obj.PreSkinCol= dt.Rows[0].ItemArray[7].ToString();
                CastProp_Obj.PreHairCol= dt.Rows[0].ItemArray[8].ToString();
                CastProp_Obj.PreEyeCol= dt.Rows[0].ItemArray[9].ToString();
                CastProp_Obj.PreBodyStruct= dt.Rows[0].ItemArray[10].ToString();
                CastProp_Obj.PreHeight= Convert.ToInt32(dt.Rows[0].ItemArray[11]);
                CastProp_Obj.CharacterDiscription= dt.Rows[0].ItemArray[12].ToString();
                CastProp_Obj.NoOfActors= Convert.ToInt32(dt.Rows[0].ItemArray[13]);
                CastProp_Obj.PostedDate = Convert.ToDateTime(dt.Rows[0].ItemArray[14]);
                CastProp_Obj.LastDate= Convert.ToDateTime(dt.Rows[0].ItemArray[15]);

            }

        }
        public string ApplicantInsert(string ActorEmail)
        {
            S1.Clear();
            S1.Add("ActorEmail", ActorEmail);
            S1.Add("CastId", CastProp_Obj.CastId);
            return Db_Obj.ExecuteProcedure("ApplicantInsert", S1);

        }
        public string ApplicantExist(string ActorEmail)
        {
            S1.Clear();
            S1.Add("ActorEmail", ActorEmail);
            S1.Add("CastId", CastProp_Obj.CastId);
            return Db_Obj.ExecuteProcedure("ApplicantExist", S1);

        }


        public List<CastingCallProperty> CallDetailsFilter(string query)
        {
            
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableDataByQuery(query);
            int Count = 0;
            List<CastingCallProperty> _list = new List<CastingCallProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                Count++;
                _list.Add(new CastingCallProperty
                {
                    CastId = Convert.ToInt32(dr["CastId"]),
                    MovieLanguage = dr["MovieLanguage"].ToString(),
                    MovieName = dr["MovieName"].ToString(),
                    ProductionName = dr["ProductionName"].ToString(),
                    PreExperience = dr["PreExperience"].ToString(),
                    CharacterDiscription = dr["CharacterDiscription"].ToString(),
                    AgeFrom = Convert.ToInt32(dr["AgeFrom"]),
                    AgeTo = Convert.ToInt32(dr["AgeTo"]),
                    PostedDate = Convert.ToDateTime(dr["PostedDate"]).ToShortDateString(),
                    FilmIcon = "~/ActorPages/Film-icon.png",
                    LastDate = Convert.ToDateTime(dr["LastDate"]).ToShortDateString(),
                    PreGender = dr["PreGender"].ToString()


                });

            }
            CastProp_Obj.Count = Count;
            return _list;
            
        }

    

        public List<CastingCallProperty> CastingDetailsByDirId()
        {
            S1.Clear();
            S1.Add("DirEmail", CastProp_Obj.DirEmail);
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData("DirectorCallBind", S1);
            int Count = 0;
            List<CastingCallProperty> _list = new List<CastingCallProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new CastingCallProperty
                {
                    CastId = Convert.ToInt32(dr["CastId"]),
                    MovieLanguage = dr["MovieLanguage"].ToString(),
                    MovieName = dr["MovieName"].ToString(),
                    ProductionName = dr["ProductionName"].ToString(),
                    PreExperience = dr["PreExperience"].ToString(),
                    CharacterDiscription = dr["CharacterDiscription"].ToString(),
                    AgeFrom = Convert.ToInt32(dr["AgeFrom"]),
                    AgeTo = Convert.ToInt32(dr["AgeTo"]),
                    PostedDate = Convert.ToDateTime(dr["PostedDate"]).ToShortDateString(),
                    NoOfActors=Convert.ToInt32(dr["NoOfActors"]),
              
                    LastDate = Convert.ToDateTime(dr["LastDate"]).ToShortDateString(),
                    PreGender = dr["PreGender"].ToString()
                });

            }
            CastProp_Obj.Count = Count;
            return _list;

        }

        public string CastingCallDelete()
        {
            S1.Clear();
            S1.Add("CastId", CastProp_Obj.CastId);
            return Db_Obj.ExecuteProcedure("CastingCallDelete", S1);
        }

        public string UpdateCastingCall()
        {
            S1.Clear();
            S1.Add("CastId", CastProp_Obj.CastId);
            S1.Add("ProductionName", CastProp_Obj.ProductionName);
            S1.Add("MovieName", CastProp_Obj.MovieName);
            S1.Add("PreGender", CastProp_Obj.PreGender);
            S1.Add("NoOfActors", CastProp_Obj.NoOfActors);
            S1.Add("AgeFrom", CastProp_Obj.AgeFrom);
            S1.Add("AgeTo", CastProp_Obj.AgeTo);
            S1.Add("CharacterDiscription", CastProp_Obj.CharacterDiscription);
            S1.Add("PreExperience", CastProp_Obj.PreExperience);
            S1.Add("MovieLanguage", CastProp_Obj.MovieLanguage);
            
            S1.Add("LastDate", CastProp_Obj.LastDate);
            return Db_Obj.ExecuteProcedure("UpdateCastingCalls", S1);
        }

        

    }
    

}
