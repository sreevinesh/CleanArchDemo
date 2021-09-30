﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CrsssRepository : ICrsssRepository
    {
        private UniversityDbContext _ctx;
        public CrsssRepository(UniversityDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Crsss> GetCrssses()
        {
            return _ctx.Crsss;
        }
    }
}
