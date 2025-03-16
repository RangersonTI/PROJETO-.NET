using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain;

namespace CL.WebAPI.Controller
{
    [Route("api/clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            return Ok(
                new List<Cliente>(){
                    new Cliente{
                        Id=1,
                        Nome="Isabela",
                        DataNascimento= new DateTime(2022,12,02,12,00,15)
                    },
                    new Cliente{
                        Id=2,
                        Nome="Igor",
                        DataNascimento= new DateTime(2023,12,02,12,00,15)
                    },
                    new Cliente{
                        Id=3,
                        Nome="Ruan",
                        DataNascimento= new DateTime(2024,12,02,12,00,15)
                    }
            });
        }

        [HttpGet("{id}")]
        public string Get(int id){
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value){

        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value){

        }

        [HttpDelete("{id}")]
        public void Delete(int id){

        }
    }
}
