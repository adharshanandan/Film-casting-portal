using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Actor.ActorPropery;
using DataAccessLayer;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer.Director.DirectorManager;
using BusinessLogicLayer.Director.DirectorProperty;




namespace BusinessLogicLayer.Actor.ActorManager
{
    public class ActorManager
    {
        public ActorRegistrationProperty RegProp_Obj = new ActorRegistrationProperty();
        private DbInterfaceHelper Db_Obj = new DbInterfaceHelper();
        SortedList S1 = new SortedList();
        public UploadVideosProperty VidProp_Obj = new UploadVideosProperty();
        public PaymentProperty PayProp_Obj = new PaymentProperty();
        public ComplaintsProperty ComProp_Obj = new ComplaintsProperty();
        public DirManager DirMng_Obj = new DirManager();
        public DirProperty DirProp_Obj = new DirProperty();


        public string InsertActorData()
        {
            RegProp_Obj.Age = DateTime.Now.Year - RegProp_Obj.ActorDob.Year;
            if (DateTime.Now.DayOfYear < RegProp_Obj.ActorDob.DayOfYear)
            {
                RegProp_Obj.Age = RegProp_Obj.Age - 1;
            }

            S1.Clear();
            S1.Add("ActorName", RegProp_Obj.ActorName);
            S1.Add("ActorGender", RegProp_Obj.ActorGender);
            S1.Add("ActorCountry", RegProp_Obj.ActorCountry);
            S1.Add("ActorDob", RegProp_Obj.ActorDob);
            S1.Add("Age", RegProp_Obj.Age);
            S1.Add("ActorAddress", RegProp_Obj.ActorAddress);
            S1.Add("ActorZip", RegProp_Obj.ActorZip);
            S1.Add("ActorState", RegProp_Obj.ActorState);
            S1.Add("ActorDist", RegProp_Obj.ActorDist);
            S1.Add("NeworExperienced", RegProp_Obj.NeworExperienced);
            S1.Add("SkinColor", RegProp_Obj.SkinColor);
            S1.Add("ActorMTng", RegProp_Obj.ActorMTng);
            S1.Add("HairCol", RegProp_Obj.HairCol);
            S1.Add("EyeCol", RegProp_Obj.EyeCol);
            S1.Add("BodyStruct", RegProp_Obj.BodyStruct);
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            S1.Add("ActorPswd", RegProp_Obj.ActorPswd);
            S1.Add("ActorPhone", RegProp_Obj.ActorPhone);
            S1.Add("Height", RegProp_Obj.Height);
            S1.Add("PreviousWorks", RegProp_Obj.PreviousWorks);
            S1.Add("ProPicActor", RegProp_Obj.ProPicActor);
            return Db_Obj.ExecuteProcedure("ActorDetailsInsert",S1);
        }
      

        public string ResetPassword()
        {
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            S1.Add("ActorPswd", RegProp_Obj.ActorPswd);
            return Db_Obj.ExecuteProcedure("ResetActorPswd", S1);

        }
        public string ValidUserOrNot()
        {
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            return Db_Obj.ExecuteProcedure("IsvalidUser", S1);

        }
        public void  ActProPicNAccType()
        {
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail.ToString());
            DataTable dt = new DataTable();
            dt=Db_Obj.GetTableData("SelectProPic", S1);
            foreach(DataRow dr in dt.Rows)
            {
                RegProp_Obj.AccType = dr["AccType"].ToString();
                RegProp_Obj.ProPicActor = dr["ProPicActor"].ToString();
            }

        }



        public void SelectActorDetails(string proc)
        {
            DataTable dt = new DataTable();
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            dt = Db_Obj.GetTableData(proc,S1);
            if(dt.Rows.Count>0)
            {
                RegProp_Obj.ActorId = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                RegProp_Obj.ActorName = dt.Rows[0].ItemArray[1].ToString();
                RegProp_Obj.ActorGender = dt.Rows[0].ItemArray[2].ToString();
                RegProp_Obj.ActorCountry = dt.Rows[0].ItemArray[3].ToString();
                RegProp_Obj.ActorDob = Convert.ToDateTime(dt.Rows[0].ItemArray[4]);
                RegProp_Obj.Age = Convert.ToInt32(dt.Rows[0].ItemArray[5]);
                RegProp_Obj.ActorAddress = dt.Rows[0].ItemArray[6].ToString();
                RegProp_Obj.ActorZip = dt.Rows[0].ItemArray[7].ToString();
                RegProp_Obj.ActorState = dt.Rows[0].ItemArray[8].ToString();
                RegProp_Obj.ActorDist = dt.Rows[0].ItemArray[9].ToString();
                RegProp_Obj.NeworExperienced = dt.Rows[0].ItemArray[10].ToString();
                RegProp_Obj.ActorMTng = dt.Rows[0].ItemArray[11].ToString();
                RegProp_Obj.SkinColor = dt.Rows[0].ItemArray[12].ToString();
                RegProp_Obj.HairCol = dt.Rows[0].ItemArray[13].ToString();
                RegProp_Obj.EyeCol = dt.Rows[0].ItemArray[14].ToString();
                RegProp_Obj.BodyStruct = dt.Rows[0].ItemArray[15].ToString();
                RegProp_Obj.ActorEmail = dt.Rows[0].ItemArray[16].ToString();
                RegProp_Obj.ActorPhone = dt.Rows[0].ItemArray[17].ToString();
                RegProp_Obj.Height = Convert.ToInt32(dt.Rows[0].ItemArray[18]);
                RegProp_Obj.PreviousWorks = dt.Rows[0].ItemArray[19].ToString();
                RegProp_Obj.ProPicActor = dt.Rows[0].ItemArray[20].ToString();
                RegProp_Obj.AccType = dt.Rows[0].ItemArray[21].ToString();
                RegProp_Obj.ActorAccStatus = Convert.ToChar(dt.Rows[0].ItemArray[22]);

            }
    
        }
        public List<ActorRegistrationProperty> SelectActorDetailsToBind()
        {
            DataTable dt = new DataTable();
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            dt = Db_Obj.GetTableData("ActorDetailsToProfile", S1);
            List<ActorRegistrationProperty> ActorList = new List<ActorRegistrationProperty>();
            foreach(DataRow dr in dt.Rows)
            {
                ActorList.Add(new ActorRegistrationProperty
                {
                    ActorName = dr["ActorName"].ToString(),
                    ActorState = dr["ActorState"].ToString(),
                    ActorDist = dr["ActorDist"].ToString(),
                    ActorGender = dr["ActorGender"].ToString()

                }) ;
            }
            return ActorList;
        }


        public string UpdatetActorData()
        {
            RegProp_Obj.Age = DateTime.Now.Year - RegProp_Obj.ActorDob.Year;
            if (DateTime.Now.DayOfYear < RegProp_Obj.ActorDob.DayOfYear)
            {
                RegProp_Obj.Age = RegProp_Obj.Age - 1;
            }

            S1.Clear();
            S1.Add("ActorName", RegProp_Obj.ActorName);
            S1.Add("ActorGender", RegProp_Obj.ActorGender);
            S1.Add("ActorCountry", RegProp_Obj.ActorCountry);
            S1.Add("ActorDob", RegProp_Obj.ActorDob);
            S1.Add("Age", RegProp_Obj.Age);
            S1.Add("ActorAddress", RegProp_Obj.ActorAddress);
            S1.Add("ActorZip", RegProp_Obj.ActorZip);
            S1.Add("ActorState", RegProp_Obj.ActorState);
            S1.Add("ActorDist", RegProp_Obj.ActorDist);
            S1.Add("NeworExperienced", RegProp_Obj.NeworExperienced);
            S1.Add("SkinColor", RegProp_Obj.SkinColor);
            S1.Add("ActorMTng", RegProp_Obj.ActorMTng);
            S1.Add("HairCol", RegProp_Obj.HairCol);
            S1.Add("EyeCol", RegProp_Obj.EyeCol);
            S1.Add("BodyStruct", RegProp_Obj.BodyStruct);
            S1.Add("ActorPhone", RegProp_Obj.ActorPhone);
            S1.Add("Height", RegProp_Obj.Height);
            S1.Add("PreviousWorks", RegProp_Obj.PreviousWorks);
            S1.Add("ProPicActor", RegProp_Obj.ProPicActor);
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            
            return Db_Obj.ExecuteProcedure("ActorDetailsUpdate", S1);
        }

        public string FollowersDataInsert(int DirId)
        {
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            S1.Add("DirId", DirId);
            return Db_Obj.ExecuteProcedure("FollowersInsert", S1);
        }

        public string UnfollowDirector()
        {
            S1.Clear();
            S1.Add("DirEmail", DirProp_Obj.DirEmail);
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            return Db_Obj.ExecuteProcedure("UnfollowDirector", S1);
        }

        public string VideosInsert()
        {
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            S1.Add("VideoLink", VidProp_Obj.VideoLink);
            S1.Add("Caption", VidProp_Obj.Caption);
            S1.Add("UploadedDate", Convert.ToDateTime(VidProp_Obj.UploadedDate));
            return Db_Obj.ExecuteProcedure("VideosDataInsert", S1);
        }

        // Function to get videos table data from database
        public List<UploadVideosProperty> VideosDataBind()
        {
            DataTable dt = new DataTable();
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            dt = Db_Obj.GetTableData("SelectVideoDetails",S1);
            List<UploadVideosProperty> _list = new List<UploadVideosProperty>();
            foreach(DataRow dr in dt.Rows)
            {
                _list.Add(new UploadVideosProperty
                {
                    VidId = Convert.ToInt32(dr["VidId"]),
                    ActorId=Convert.ToInt32(dr["ActorId"]),
                    VideoLink=dr["VideoLink"].ToString(),
                    Caption=dr["Caption"].ToString(),
                    UploadedDate=Convert.ToDateTime(dr["UploadedDate"]).ToShortDateString()
                   

                }) ;
            }
            return _list;

        }
        public string VideoDelete()
        {
            S1.Clear();
            S1.Add("VidId", VidProp_Obj.VidId);
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            return Db_Obj.ExecuteProcedure("VideoDelete", S1);
        }
        public void SelectAccMailId()
        {
            S1.Clear();
            S1.Add("AccHolder", PayProp_Obj.AccHolder);
            S1.Add("BankName", PayProp_Obj.BankName);
            S1.Add("Branch", PayProp_Obj.Branch);
            S1.Add("BAccNo", PayProp_Obj.BAccNo);
            S1.Add("IfscCode", PayProp_Obj.IfscCode);
            PayProp_Obj.Email= Db_Obj.ExecuteProcedure("SelectAccMail", S1);
        }


        public string PayAmount()
        {
            if (PayProp_Obj.Amount == 300)
            {
                PayProp_Obj.StartDate = DateTime.Now;
                PayProp_Obj.EndDate = PayProp_Obj.StartDate.AddDays(30);

            }
            else
            {
                PayProp_Obj.StartDate = DateTime.Now;
                PayProp_Obj.EndDate = PayProp_Obj.StartDate.AddDays(365);
            }
            
            S1.Clear();
            S1.Add("BAccNo", PayProp_Obj.BAccNo);
            S1.Add("Amount", PayProp_Obj.Amount);
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            S1.Add("StartDate", PayProp_Obj.StartDate);
            S1.Add("EndDate", PayProp_Obj.EndDate);
            return Db_Obj.ExecuteProcedure("PayAmount",S1);
        }

        public string GetBalanceInfo()
        {
            S1.Clear();
            S1.Add("BAccNo", PayProp_Obj.BAccNo);
            return Db_Obj.ExecuteProcedure("GetBalAmount",S1);


        }
        public string InsertComplaint()
        {
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            S1.Add("Complaints", ComProp_Obj.Complaints);
            return Db_Obj.ExecuteProcedure("ComplaintsInsertActor", S1);
        }

        public List<ActorRegistrationProperty> ApplicantDetails()
        {
            S1.Clear();
            S1.Add("DirEmail", RegProp_Obj.ActorEmail);
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableData("SelectApplicantDetails",S1);
            List<ActorRegistrationProperty> _list = new List<ActorRegistrationProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new ActorRegistrationProperty
                {

                    ActorEmail = dr["ActorEmail"].ToString(),
                    ActorName = dr["ActorName"].ToString(),
                    ActorGender=dr["ActorGender"].ToString(),
                    Age = Convert.ToInt32(dr["Age"]),
                    ProPicActor = dr["ProPicActor"].ToString(),
                    ActorState = dr["ActorState"].ToString(),
                    ActorDist = dr["ActorDist"].ToString(),
                    NeworExperienced = dr["NeworExperienced"].ToString(),
                    ActorPhone = dr["ActorPh"].ToString(),
                    AccType = dr["AccType"].ToString()


                });
            }
            return _list;


        }

        public List<ActorRegistrationProperty> ApplicantsFilter(string query)
        {
            
            DataTable dt = new DataTable();
            dt = Db_Obj.GetTableDataByQuery(query);
            List<ActorRegistrationProperty> _list = new List<ActorRegistrationProperty>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new ActorRegistrationProperty
                {

                    ActorEmail = dr["ActorEmail"].ToString(),
                    ActorName = dr["ActorName"].ToString(),
                    Age = Convert.ToInt32(dr["Age"]),
                    ProPicActor = dr["ProPicActor"].ToString(),
                    ActorState = dr["ActorState"].ToString(),
                    ActorDist = dr["ActorDist"].ToString(),
                    ActorGender=dr["ActorGender"].ToString(),
                    NeworExperienced = dr["NeworExperienced"].ToString(),
                    ActorPhone = dr["ActorPh"].ToString(),
                    AccType = dr["AccType"].ToString()


                });
            }
            return _list;


        }

       
        public DateTime GetPremiumEndDate()
        {
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            return Convert.ToDateTime(Db_Obj.ExecuteProcedure("SelectPremiumEndDate", S1));

        }

        public string ChangePremiumToNormal()
        {
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            return Db_Obj.ExecuteProcedure("ChangePremiumToNormal", S1);

        }

        public string GetActAccType()
        {
            S1.Clear();
            S1.Add("ActorEmail", RegProp_Obj.ActorEmail);
            return Db_Obj.ExecuteProcedure("GetActAccType",S1);
        }


    }

}
