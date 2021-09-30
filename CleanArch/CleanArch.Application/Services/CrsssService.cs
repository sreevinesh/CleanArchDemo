using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CrsssService : ICrsssService
    {
        private ICrsssRepository _crsssRepository;
        public CrsssService(ICrsssRepository CrsssRepository)
        {
            _crsssRepository = CrsssRepository;
        }
        public CrsssViewModel GetCrssses()
        {
            return new CrsssViewModel()
            {
                Crsss = _crsssRepository.GetCrssses()
        };
        }
    }
}
