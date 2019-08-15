using System;
using AutoMapper;
using QuotesApp.Domain.Entities;

namespace QuotesApp.Application.DTOs
{
    public class Mappings
    {
        public static IMapper Setup()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Quote, QuoteOutputDto>().ReverseMap();
                cfg.CreateMap<QuoteInputDto, Quote>().ReverseMap();
            });

            return config.CreateMapper();
        }
    }
}
