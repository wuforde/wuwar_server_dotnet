using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.DependencyInjection;
using Wu.WuDeck;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDistributedMemoryCache();

        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromSeconds(10);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });

        var app = builder.Build();

        app.UseFileServer();
        app.UseSession();

        app.MapGet("/test",() => "hello world");
        app.MapGet("/init", ()=> new WuDeck().Deal(2));
        app.MapGet("/draw", () => "Draw");
        
        app.Run();
    }
}