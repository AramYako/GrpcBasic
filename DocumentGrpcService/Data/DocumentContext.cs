using DocumentGrpcService.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentGrpcService.Data
{
    public class DocumentContext:DbContext
    {
        public DocumentContext(DbContextOptions<DocumentContext> options)
            :base(options)
        {

        }

        public DbSet<Document> Documents { get; set; }
    }
}
