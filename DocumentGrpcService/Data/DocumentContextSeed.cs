using DocumentGrpcService.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentGrpcService.Data
{
    public class DocumentContextSeed
    {
        public static void SeedDatabase(DocumentContext documentContext)
        {
            if (!documentContext.Documents.Any())
            {
                var documents = new List<Document>()
                {
                    new Document
                    {
                         ClientId = 1,
                        DocumentType ="pdf", 
                        Name = "InvoiceOne"
                    },
                    new Document
                    {
                         ClientId = 2,
                        DocumentType ="pdf",
                        Name = "InvoiceTwo"
                    },
                    new Document
                    {
                         ClientId = 2,
                        DocumentType ="pdf",
                        Name = "InvoiceThree"
                    },
                };

                documentContext.Documents.AddRange(documents);

                documentContext.SaveChanges();

            }

        }
    }
}
