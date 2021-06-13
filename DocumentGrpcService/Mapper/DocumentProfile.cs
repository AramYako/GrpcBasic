using AutoMapper;
using DocumentGrpcService.Model.Entities;
using DocumentGrpcService.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentGrpcService.Mapper
{
    public class DocumentProfile:Profile
    {
        public DocumentProfile()
        {
            CreateMap<DocumentModel, Document>()
                .ReverseMap()
                .ForMember(dest => dest.DocumentId, src => src.MapFrom(src => src.Id));

            CreateMap<CreateDocumentModelRequest, Document>()
                .ReverseMap();
        }
    }
}
