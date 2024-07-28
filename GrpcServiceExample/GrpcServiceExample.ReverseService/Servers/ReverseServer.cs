using Grpc.Core;
using GrpcServiceExample.ReverseService.Services;

namespace GrpcServiceExample.ReverseService.Servers
{
    public class ReverseServer
    {
        private readonly Server _server;

        public ReverseServer()
        {
            _server = new Server()
            {
                Services = { RevService.Generated.RevService.BindService(new ReverseServiceImplementation()) },
                Ports = { new ServerPort("localhost", 11111, ServerCredentials.Insecure) }
            };
        }

        public void Start()
        {
            _server.Start();
        }

        public async Task ShutdownAsync()
        {
            await _server.ShutdownAsync();
        }
    }
}
