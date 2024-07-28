using Grpc.Core;
using RevService.Generated;
using static RevService.Generated.RevService;

namespace GrpcServiceExample.ReverseService.Services
{
    public class ReverseServiceImplementation : RevServiceBase
    {
        public override Task<Data> Reverse(Data request, ServerCallContext context)
        {
            var response = new Data { Str = new string(request.Str.Reverse().ToArray()) };

            return Task.FromResult(response);
        }
    }
}
