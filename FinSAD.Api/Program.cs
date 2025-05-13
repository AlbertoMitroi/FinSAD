using FinSAD.Application;
using FinSAD.Domain.Entities;
using FinSAD.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.RegisterApplication();
    builder.Services.RegisterRepositories();
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" }));
    builder.Services.AddDbContext<DataDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
    builder.Services.AddAuthorization();
    builder.Services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme);

    builder.Services.AddIdentityCore<User>()
        .AddEntityFrameworkStores<DataDbContext>()
        .AddApiEndpoints();
}
    
var app = builder.Build();

{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));

    app.UseHttpsRedirection();
    app.MapControllers();
    app.MapIdentityApi<User>();
    app.Run();
}