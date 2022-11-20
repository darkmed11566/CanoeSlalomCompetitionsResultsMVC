using CanoeSlalomCompetitionsResults.EfStaff.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanoeSlalomCompetitionsResults.EfStaff.Repositories
{
    public class CompetitonRepository:BaseRepository<Competition>
    {
        public CompetitonRepository(WebContext webContext) : base(webContext)
        {

        }
    }
}
