
// namespace WebAPI{
//     public class Program{ 

//         // public static void Main(string[] args){
//         //     CreateHostBuilder(args).Build().Run();
//         // }

//         // public static IHostBuilder CreateHostBuilder(string[] args)
//         //     => Host.CreateDefaultBuilder(args)
//         //             .ConfigureWebHostDefaults(
//         //                 webBuilder =>{
//         //                     webBuilder.UseStartup<Program>();
//         //             });



//         public void ConfigureServices(IServiceCollection services){
//             services.AddControllers();

//             services.AddSwaggerGen(
//                 c => c.SwaggerDoc("v1", new OpenApiInfo {Title="Consultório Legal", Version="v1"})
//             );
//         }

//         public void Configure(IApplicationBuilder app, IWebHostEnvironment env){

//             // var builder = WebApplication.CreateBuilder();
   
//             if(env.IsDevelopment()){
//                 app.UseDeveloperExceptionPage();
//             }

//             app.UseSwagger();
//             app.UseSwaggerUI(
//                 c => {
//                     c.SwaggerEndpoint("./swagger/v1/swagger.json", "CL v1");
//                     c.RoutePrefix = string.Empty;
//                 }

//             );

//             app.UseRouting();
//             // app.UseHttpsRedirection();
//             // app.UseAuthentication();

//             app.UseEndpoints(
//                 endPoint => endPoint.MapControllers()
//             );
            
//             //var build = builder.Build();
//             //build.Run();
//         }
//     }
// }


// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();              // Adiciona controllers
builder.Services.AddSwaggerGen();               // Adiciona o serviço do Swagger
builder.Services.AddEndpointsApiExplorer();

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
    }
);

// app.UseRouting();
// app.UseAuthentication();
app.UseHttpsRedirection();

// app.UseAuthorization();
app.MapControllers();
app.Run();