using ApiStock.Application.Models.Products;
using ApiStock.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiStock.Application.Mappers
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductModel, ProductModel>()
                .ForMember(d => d.Id, opt => opt.Ignore())
                .ForMember(d => d.Name, (o) => o.MapFrom(src => src.Name))
                .ForMember(d => d.AmountInStock, (o) => o.MapFrom(src => src.AmountInStock))
                .ForMember(d => d.UnitPrice, (o) => o.MapFrom(src => src.UnitPrice));

            CreateMap<ProductModel, CreateProductViewModel>()
                .ForMember(d => d.Id, (o) => o.MapFrom(src => src.Id))
                .ForMember(d => d.Name, (o) => o.MapFrom(src => src.Name))
                .ForMember(d => d.AmountInStock, (o) => o.MapFrom(src => src.AmountInStock))
                .ForMember(d => d.UnitPrice, (o) => o.MapFrom(src => src.UnitPrice));

            CreateMap<ProductModel, ProductViewModel>()
                .ForMember(d => d.Id, (o) => o.MapFrom(src => src.Id))
                .ForMember(d => d.Name, (o) => o.MapFrom(src => src.Name))
                .ForMember(d => d.AmountInStock, (o) => o.MapFrom(src => src.AmountInStock))
                .ForMember(d => d.UnitPrice, (o) => o.MapFrom(src => src.UnitPrice));

            CreateMap<UpdateProductModel, ProductModel>()
                .ForMember(d => d.Id, (o) => o.MapFrom(src => src.Id))
                .ForMember(d => d.Name, (o) => o.MapFrom(src => src.Name))
                .ForMember(d => d.AmountInStock, (o) => o.MapFrom(src => src.AmountInStock))
                .ForMember(d => d.UnitPrice, (o) => o.MapFrom(src => src.UnitPrice));
        }
    }
}
