using System;
using CurriculumVitae.DataStandard.Context;
using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;

namespace CurriculumVitae.DataStandard.Repository
{
    public class ContactRepository : RespositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(CurriculumVitaeContext context) : base(context)
        {
        }
    }
}