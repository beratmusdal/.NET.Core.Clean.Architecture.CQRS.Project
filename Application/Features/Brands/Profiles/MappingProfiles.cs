using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using Application.Responses;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();
        CreateMap<Brand, GetListBrandListItemDto>().ReverseMap();
        CreateMap<Paginate<Brand>, GetListResponse<GetListBrandListItemDto>>().ReverseMap();


    }
}
