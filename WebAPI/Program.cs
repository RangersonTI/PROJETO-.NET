
using Data.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();              // Adiciona controllers
builder.Services.AddSwaggerGen();               // Adiciona o serviço do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<CLContext>(options => options.UseSqlServer(
    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog= DB; Integrated Security=True; Connect Timeout=30; Encrypt=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False"
));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(
    c => {
        c.RoutePrefix = string.Empty;
        c.SwaggerEndpoint("./swagger/v1/swagger.json", "CL V1");
        c.InjectStylesheet("/swagger-ui/custom.css");
    }
);

// app.UseRouting();
// app.UseAuthentication();
app.UseHttpsRedirection();

// app.UseAuthorization();
app.MapControllers();
app.Run();