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
        public DateTime CompetitionDateStart { get; set; }
        public DateTime CompetitionDateEnd { get; set; }
        public string CompetitionName { get; set; }
        public bool CompetitionRating { get; set; }
        public CompetitionType Type { get; set; }
        public Country CountryOfCompetition { get; set; }
        public virtual List<CompetitionTrack> Tracks { get; set; }
        public virtual List<BoatClassCategory> BoatClasses { get; set; }

    }
}
