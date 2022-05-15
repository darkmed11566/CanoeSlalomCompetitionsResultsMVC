using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class StartingGate : Gate
    {
        public DateTime MarkCrossingTime { get; set; }
    }
}
