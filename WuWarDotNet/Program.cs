using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.DependencyInjection;
using WuDeckLib;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDistributedMemoryCache();

        var app = builder.Build();

        app.UseFileServer();

        app.MapGet("/test",() => "hello world");
        app.MapGet("/init", ()=>  new WuDeck().Deal(2));
        app.MapGet("/cut", () => {
            WuDeck deck = new WuDeck();
            deck.Shuffle();
            deck.Cut(5);
            deck.Shuffle();
            return deck;
        });
        app.MapGet("/draw", () => "Draw");

        app.Run("http://*:" + (args == null ? args[0] : "4949"));
    }
}
