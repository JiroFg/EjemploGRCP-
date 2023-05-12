using Grpc.Net.Client;
using ClientGRPC;

using (var channel = GrpcChannel.ForAddress("https://localhost:7116"))
{
    var client = new Greeter.GreeterClient(channel);
    var reply = await client.SayHelloAsync(new HelloRequest
    {
        Name = "Alex"
    });

    Console.WriteLine(reply.Message);
    Console.ReadKey();
}