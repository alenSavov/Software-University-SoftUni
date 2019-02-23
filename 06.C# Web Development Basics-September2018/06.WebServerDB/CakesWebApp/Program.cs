using CakesWebApp.Controllers;
using SIS.HTTP.Enums;
using SIS.WebServer;
using SIS.WebServer.Routing;
using System;

namespace CakesWebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Routes[HttpRequestMethod.GET]["/"] = request =>
                 new HomeController().Index(request);
            serverRoutingTable.Routes[HttpRequestMethod.GET]["/register"] = request =>
                new AccountController().Register(request);
            serverRoutingTable.Routes[HttpRequestMethod.GET]["/login"] = request =>
                new AccountController().Login(request);
            serverRoutingTable.Routes[HttpRequestMethod.POST]["/register"] = request =>
                new AccountController().DoRegister(request);




            Server server = new Server(80, serverRoutingTable);

            server.Run();
        }
    }
}
