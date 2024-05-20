using Test.Backend.Dotnet1.Api.Models;
using Test.Backend.Dotnet1.Core.Entities;

using AutoMapper;

namespace Test.Backend.Dotnet1.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
