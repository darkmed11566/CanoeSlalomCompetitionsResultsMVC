using CanoeSlalomCompetitionsResults.Servise.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class GatePassage:Gate
    {
        public virtual Gate Id { get; set;}
        public PenaltyConstans PenaltyInGate { get; set; }
        public DateTime GatePassageTime { get; set; }
    }
}
