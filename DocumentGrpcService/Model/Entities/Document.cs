using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentGrpcService.Model.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DocumentType { get; set; }
        public int ClientId { get; set; }
    }
}