using EServicesAPI;
using EServicesAPI.Services;
using Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/users", (IUserService userService) =>
{
    var users = userService.GetUsers();
    return users;
})
.WithName("GetUsers")
.WithOpenApi();

app.MapPost("/login", (UserDto userDto,IUserService userService) =>
{
    var _userDto = userService.Login(userDto);
    if (_userDto == null)
    {
        return null;
    }
    return _userDto;
})
.WithName("Login")
.WithOpenApi();



app.Run();
