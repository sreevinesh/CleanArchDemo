using CleanArch.Domain.Commands;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.CommandHandlers
{
    public class CrsssCommandHandler : IRequestHandler<CreateCrsssCommand, bool>
    {
        private readonly ICrsssRepository _crsssRepository;
        public CrsssCommandHandler(ICrsssRepository crsssRepository)
        {
            _crsssRepository = crsssRepository;
        }
        public Task<bool> Handle(CreateCrsssCommand request, CancellationToken cancellationToken)
        {
            var crsss = new Crsss()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };
            _crsssRepository.Add(crsss);
            return Task.FromResult(true);
        }
    }
}
