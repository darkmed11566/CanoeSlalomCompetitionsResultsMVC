using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class GateBundle : BaseModel
    {
        public int BundleNumber { get; set; }      
        public string PasswordBundl { get; set; }        
        public virtual CompetitionTrack Track { get; set;}
        public virtual Judge JudgeSecondName { get; set; }
        public virtual List<Gate> Gates { get; set; }

    }
}
