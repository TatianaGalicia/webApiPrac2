using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiPrac2.Models;
using Microsoft.EntityFrameworkCore;

namespace webApiPrac2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;
        public equiposController(equiposContext equiposContexto)
        {
            _equiposContexto = equiposContexto;
                }
    }
}
