using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
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
        private readonly ICrsssRepository _crsssRepository;
        private readonly IMediatorHandler _bus;
        public CrsssService(ICrsssRepository CrsssRepository, IMediatorHandler bus)
        {
            _crsssRepository = CrsssRepository;
            _bus = bus;
        }

        public void Create(CrsssViewModel crsssViewModel)
        {
            var createCrsssCommand = new CreateCrsssCommand(
                crsssViewModel.Name,
                crsssViewModel.Description,
                crsssViewModel.ImageUrl
                );
            _bus.SendCommand(createCrsssCommand);
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
