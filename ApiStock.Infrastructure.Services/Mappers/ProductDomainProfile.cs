using ApiStock.Domain.Models;
using ApiStock.Infrastructure.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiStock.Infrastructure.Services.Mappers
{
    public class ProductDomainProfile : Profile
    {
        public ProductDomainProfile()
        {
            CreateMap<ProductModel, Product>()
                .ForMember(d => d.Name, (o) => o.MapFrom(src => src.Name))
                .ForMember(d => d.AmountInStock, (o) => o.MapFrom(src => src.AmountInStock))
                .ForMember(d => d.UnitPrice, (o) => o.MapFrom(src => src.UnitPrice))
                .AfterMap((src, dst) =>
                {
                    if (string.IsNullOrWhiteSpace(src.Id)) 
                    {
                        dst.Id = Guid.NewGuid().ToString();
                    }
                }
            );

            CreateMap<Product, ProductModel>()
                .ForMember(d => d.Id, (o) => o.MapFrom(src => src.Id))
                .ForMember(d => d.Name, (o) => o.MapFrom(src => src.Name))
                .ForMember(d => d.AmountInStock, (o) => o.MapFrom(src => src.AmountInStock))
                .ForMember(d => d.UnitPrice, (o) => o.MapFrom(src => src.UnitPrice));
        }
    }
}
