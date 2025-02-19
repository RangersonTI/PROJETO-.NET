using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CL.WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Cliente> Get(){
            return ["value1","value2"];
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
