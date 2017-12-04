using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Authentication;
using Microsoft.Azure.Mobile.Server.Config;
using ListaComprasAppService.DataObjects;
using ListaComprasAppService.Models;
using Owin;

namespace ListaComprasAppService
{
    public partial class Startup
    {
        public static void ConfigureMobileApp(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            //For more information on Web API tracing, see http://go.microsoft.com/fwlink/?LinkId=620686 
            config.EnableSystemDiagnosticsTracing();

            new MobileAppConfiguration()
                .UseDefaultConfiguration()
                .ApplyTo(config);

            // Use Entity Framework Code First to create database tables based on your DbContext
            Database.SetInitializer(new ListaComprasAppInitializer());

            // To prevent Entity Framework from modifying your database schema, use a null database initializer
            // Database.SetInitializer<ListaComprasAppContext>(null);

            MobileAppSettingsDictionary settings = config.GetMobileAppSettingsProvider().GetMobileAppSettings();

            if (string.IsNullOrEmpty(settings.HostName))
            {
                // This middleware is intended to be used locally for debugging. By default, HostName will
                // only have a value when running in an App Service application.
                app.UseAppServiceAuthentication(new AppServiceAuthenticationOptions
                {
                    SigningKey = ConfigurationManager.AppSettings["SigningKey"],
                    ValidAudiences = new[] { ConfigurationManager.AppSettings["ValidAudience"] },
                    ValidIssuers = new[] { ConfigurationManager.AppSettings["ValidIssuer"] },
                    TokenHandler = config.GetAppServiceTokenHandler()
                });
            }
            app.UseWebApi(config);
        }
    }

    public class ListaComprasAppInitializer : CreateDatabaseIfNotExists<ListaComprasAppContext>
    {
        protected override void Seed(ListaComprasAppContext context)
        {
            List<ListaCompras> listas = new List<ListaCompras>
            {
                new ListaCompras
                {
                    Titulo = "Teste 1",
                    Data = DateTime.Now,
                    Finalizado = false,
                    Observacao = "Teste de lista de compras 1",
                    Items = new List<Item>
                    {
                        new Item
                        {
                            Nome = "Nescau",
                            Quantidade = 2,
                            Concluido = false
                        },

                        new Item
                        {
                            Nome = "Toddy",
                            Quantidade = 1,
                            Concluido = true
                        }
                    }
                },
            };

            foreach (ListaCompras lista in listas)
            {
                context.Set<ListaCompras>().Add(lista);
            }

            base.Seed(context);
        }
    }
}

