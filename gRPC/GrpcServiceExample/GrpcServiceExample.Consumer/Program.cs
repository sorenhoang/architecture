using Grpc.Core;

var reverseString = Reverse().GetAwaiter().GetResult();
Console.WriteLine(reverseString);
Console.ReadKey();

static async Task<string> Reverse()
{
    Channel channel = new Channel("localhost", 11111, ChannelCredentials.Insecure);
    RevService.Generated.RevService.RevServiceClient client = new RevService.Generated.RevService.RevServiceClient(channel);

    var data = new RevService.Generated.Data { Str = "soren text example" };

    var res = await client.ReverseAsync(data);

    return res.Str;

}