using GrpcServiceExample.ReverseService.Servers;

ReverseServer reverseServer = new ReverseServer();
reverseServer.Start();
Console.WriteLine("Server is listening...");
Console.WriteLine("Press any key to stop server...");
Console.ReadKey();