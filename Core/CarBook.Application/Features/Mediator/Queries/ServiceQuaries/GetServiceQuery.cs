﻿using CarBook.Application.Features.Mediator.Results.ServiceResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.ServiceQuaries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
    {
    }
}
