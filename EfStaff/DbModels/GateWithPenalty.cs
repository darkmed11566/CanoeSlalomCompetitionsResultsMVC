using CanoeSlalomCompetitionsResults.Servise.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class GateWithPenalty:Gate
    {
        public int GateNumber { get; set; }
        public PenaltyConstans PenaltyInGate { get; set; }
    }
}
