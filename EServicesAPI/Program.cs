using EServicesAPI;
using EServicesAPI.Services;
using Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
            policy =>
            {
                policy.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
});
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

app.MapPost("/login", (UserDto userDto, IUserService userService) =>
{
    var _userDto = userService.Login(userDto);
    if (_userDto == null)
    {
        return null;
    }

    if (_userDto.UserType == UserType.Admin)
    {
        var userDtos = userService.GetUsers();
        var userResponse = new UserResponse()
        {
            UserDtos = userDtos,
            UserDto = _userDto
        };
        return userResponse;
    }

    return new UserResponse()
    {
        UserDto = _userDto,
    };
})
.WithName("Login")
.WithOpenApi();

app.Run();
