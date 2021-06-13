using ClientGrpcService.Protos;
using DocumentGrpcService.Protos;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientWorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();

                    //registered as transient
                    services.AddGrpcClient<ClientProtoService.ClientProtoServiceClient>(options =>
                    {
                        options.Address = new Uri(hostContext.Configuration.GetSection("GrpcSettings:GrpcClientChannel").Value);
                    })
                    .ConfigurePrimaryHttpMessageHandler(() =>
                    {
                        var handler = new HttpClientHandler();
                        return handler;
                    }).ConfigureChannel(options => { 
                       // options.Credentials = new CustomCredentials()
                    });

                    services.AddGrpcClient<DocumentProtoService.DocumentProtoServiceClient>(options =>
                    {
                        options.Address = new Uri(hostContext.Configuration.GetSection("GrpcSettings:GrpcDocumentChannel").Value);
                    });

                });
    }
}
