using CanoeSlalomCompetitionsResults.Servise.EnamsAndConstans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class GateViewModel
    {
        public int NumberOfGate { get; set; }
        public GateTypes GateType { get; set; }

    }
}
