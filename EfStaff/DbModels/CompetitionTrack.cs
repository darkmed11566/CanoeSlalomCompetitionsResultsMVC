using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class CompetitionTrack : BaseModel
    {
        public string NameOfCompetitionTrack { get; set; }        
        public virtual Competition CompetitionName { get; set; }
        public virtual List<GateBundle> GateBundles { get; set; }

    }
}
