using CurriculumVitae.Domain.Interfaces.Repository;
using CurriculumVitae.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Data.Repository
{
    public class ProfileRepository : RespositoryBase<Profile>, IProfileRepository
    {
    }
}
