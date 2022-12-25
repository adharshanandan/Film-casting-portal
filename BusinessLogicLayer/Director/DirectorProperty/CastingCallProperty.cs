using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Director.DirectorProperty
{
    public class CastingCallProperty
    {
        public int Count { get; set; }
        public int CastId { get; set; }
        public int DirectorId { get; set; }
        public string PreGender { get; set; }
        public string DirEmail { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public string PreExperience { get; set; }
        public string PreCountry { get; set; }
        public string PreState { get; set; }
        public string PreDist { get; set; }
        public string PreSkinCol { get; set; }
        public string PreHairCol { get; set; }
        public string PreEyeCol { get; set; }
        public string PreBodyStruct { get; set; }
        public int PreHeight { get; set; }
        public string CharacterDiscription { get; set; }
        public int NoOfActors { get; set; }
        public string ProductionName { get; set; }
        public string FilmIcon { get; set; }

        public object PostedDate { get; set; }
    
        public object LastDate { get; set; }
        public string MovieName { get; set; }
        public string MovieLanguage { get; set; }
    }
}
