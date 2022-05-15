using CanoeSlalomCompetitionsResults.Servise.Enams;
using CanoeSlalomCompetitionsResults.Servise.EnamsAndConstans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class CompetitorViewModel
    {
        public int Number { get; set; }
        public BoatClassCategory BoatClassCategory { get; set; }
        public StatusSportsmanInTrackEnums Status { get; set; }
         

    }
}
