using CanoeSlalomCompetitionsResults.Servise.Enams;
using CanoeSlalomCompetitionsResults.Servise.EnamsAndConstans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.DbModels
{

    public class SportsmanViewModel
    {
        public string CompetitorName { get; set; }
        public string CompetitorSecondName { get; set; }
        public DateTime YearOfBirth { get; set; }
        public Sex SexCompetito { get; set; }
        public Country CountryOfSportsman { get; set; }
        public string ClubOrOrganization { get; set; }
        public string SecondNameOfTheCoach { get; set; }

    }
}
