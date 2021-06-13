using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientGrpcService.Model.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientSecret { get; set; }
    }
}
