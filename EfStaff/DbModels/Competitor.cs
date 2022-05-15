using CanoeSlalomCompetitionsResults.Servise.Enams;
using CanoeSlalomCompetitionsResults.Servise.EnamsAndConstans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class Competitor : BaseModel
    {
        public int Number { get; set; }
        public virtual BoatClassCategory BoatClassCategory { get; set; }
        public virtual Sportsman Id { get; set; }
        public virtual StatusSportsmanInTrackEnums Status { get; set; }
        public virtual 

    }
}
