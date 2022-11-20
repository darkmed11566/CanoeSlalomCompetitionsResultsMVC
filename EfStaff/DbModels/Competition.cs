using CanoeSlalomCompetitionsResults.Servise.Enams;
using CanoeSlalomCompetitionsResults.Servise.EnamsAndConstans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class Competition : BaseModel
    {
        public string CompetitionName { get; set; }
        public DateTime CompetitionStartData { get; set; }
        public DateTime CompetitionEndtData { get; set; }
        public bool Rating { get; set; }
        public CompetitionType Type { get; set; }
        public ListOfCountries Country { get; set; }
        public CompetitionStatus Status { get; set; }
    }
}
