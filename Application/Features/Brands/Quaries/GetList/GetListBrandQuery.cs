using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Request;
using Core.Application.Response;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Quaries.GetList
{
    //müşteriden gelen istek
    public class GetListBrandQuery:IRequest<GetListRepsonse<GetListBrandListItemDto>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, GetListRepsonse<GetListBrandListItemDto>>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<GetListRepsonse<GetListBrandListItemDto>> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
            {
               Paginate<Brand> brands= await _brandRepository.GetListAsync
                    (
                    index: request.PageRequest.PageIndex,
                    size:request.PageRequest.PageSize,
                    cancellationToken:cancellationToken
                    ) ;

                GetListRepsonse<GetListBrandListItemDto> repsonse = _mapper.Map<GetListRepsonse<GetListBrandListItemDto>>(brands);
                return repsonse;
            }
        }
    }
}
