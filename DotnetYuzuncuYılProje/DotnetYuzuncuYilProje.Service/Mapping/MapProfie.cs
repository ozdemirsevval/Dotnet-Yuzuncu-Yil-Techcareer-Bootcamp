using AutoMapper;
using DotnetYuzuncuYilProje.Core;
using DotnetYuzuncuYilProje.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProje.Service.Mapping
{
    public class MapProfie:Profile
    {
        public MapProfie() 
        {
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<Audience, AudienceDto>().ReverseMap();
            CreateMap<Ticket, TicketDto>().ReverseMap();
        }
    }
}
