using CarBook.Application.Features.Mediator.Queries.FootAddressQuaries;
using CarBook.Application.Features.Mediator.Results.FeatureResults;
using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

       async Task<List<GetFooterAddressQueryResult>> IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>.Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
               Address = x.Address,
               FooterAdressID = x.FooterAdressID,
               Email = x.Email,
               Description = x.Description,
               Phone = x.Phone


            }).ToList();
        }
    }
}
