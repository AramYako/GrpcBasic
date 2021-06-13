using AutoMapper;
using ClientGrpcService.Model.Entities;
using ClientGrpcService.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientGrpcService.Mapper
{
    public class ClientProfile: Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientModel>().ForMember(dest => dest.ClientId, src => src.MapFrom(src => src.Id)).ReverseMap();
        }
    }
}
