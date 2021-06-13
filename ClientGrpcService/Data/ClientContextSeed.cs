using ClientGrpcService.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientGrpcService.Data
{
    public class ClientContextSeed
    {
        public static void SeedDatabase(ClientContext clientContext)
        {
            if (!clientContext.Clients.Any())
            {
                var clients = new List<Client>()
                {
                    new Client
                    {
                          ClientName ="Arams Ab",
                           ClientSecret ="King"
                    },
                    new Client
                    {
                          ClientName ="Arams Ab Jr",
                           ClientSecret ="King Jr"
                    },
                };

                clientContext.Clients.AddRange(clients);

                clientContext.SaveChanges();

            }

        }
    }
}
