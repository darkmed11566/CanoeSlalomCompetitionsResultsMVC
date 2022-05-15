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
    }
}
