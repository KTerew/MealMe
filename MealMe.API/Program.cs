using MealMe.Data.MealMeContext;
using MealMe.Services.Services.CuisineServices;
using MealMe.Services.Configurations;
using MealMe.Services.Services.MealServices;
using Microsoft.EntityFrameworkCore;
using MealMe.Services.Services.IngredientServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MealMeDBContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<ICuisineServices,CuisineServices>();
builder.Services.AddScoped<IMealServices,MealServices>();
builder.Services.AddAutoMapper(typeof(MappingConfigurations));
builder.Services.AddScoped<IIngredientServices,IngredientServices>();
//builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
