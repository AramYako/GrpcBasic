using ClientGrpcService.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientGrpcService.Data
{
    public class ClientContext:DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
            :base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}
