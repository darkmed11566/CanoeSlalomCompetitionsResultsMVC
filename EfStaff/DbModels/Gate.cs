using CanoeSlalomCompetitionsResults.Servise.EnamsAndConstans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class Gate : BaseModel
    {
        public GateTypes GateType { get; set; }
        public virtual GateBundle Bundle { get; set; }        

    }
}
