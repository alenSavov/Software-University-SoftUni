namespace HTTP_Server
{
    using HTTP_Server.Contracts;


    public static class StartUp
    {
        public static void Main()
        {
            IHttpServer server = new HttpServer();
            server.Start();
        }
    }
}
