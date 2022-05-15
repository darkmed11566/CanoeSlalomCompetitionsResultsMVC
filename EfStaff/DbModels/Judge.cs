using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{
    public class Judge : BaseModel
    {
        public string JudgeName { get; set; }
        public string JudgeSecondName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
