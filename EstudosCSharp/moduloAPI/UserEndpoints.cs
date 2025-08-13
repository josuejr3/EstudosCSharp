using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace moduloAPI
{
    
    public class MensagemResponse
    {
        public string Message { get; set; }
    }


    public static class UserEndpoints
    {
        private static List<User> users = new List<User>();

        public static void MapUserEndpoints(this WebApplication app)
        {
            app.MapGet("/users", () =>
            {
                return users;
            }).WithTags("Users");

            app.MapGet("/users/{id}", (int id) =>
            {
                var user = users.FirstOrDefault(u => u.Id == id);
                return user is not null ? Results.Ok(user) : Results.NotFound();
            }).WithTags("Users");

            app.MapPost("/users", (User user) =>
            {
                users.Add(user);
                return Results.Created($"/users/{user.Id}", user);
            }).WithTags("Users");

            app.MapDelete("/users/{id}", (int id) =>
            {
                var user = users.FirstOrDefault(u => u.Id == id);
                if (user is null) return Results.NotFound();
                users.Remove(user);
                return Results.NoContent();
            }).WithTags("Users");

            app.MapGet("/apresentar/{nome}", (string nome) =>
            {
                var message = $"Olá, {nome}";
                return new MensagemResponse { Message = $"Olá, {nome}" };
            }).WithTags("Users");

        }
    }
}
