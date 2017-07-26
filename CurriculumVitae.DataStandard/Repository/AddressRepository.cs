using CurriculumVitae.DomainStandard.Interfaces.Repository;
using CurriculumVitae.DomainStandard.Models;
using System;
using System.Collections.Generic;
using System.Text;
using CurriculumVitae.DataStandard.Context;

namespace CurriculumVitae.DataStandard.Repository
{
    public class AddressRepository : RespositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(CurriculumVitaeContext context) : base(context)
        {

        }

    }
}
