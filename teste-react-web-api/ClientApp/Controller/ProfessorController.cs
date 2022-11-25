using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using teste_react_web_api.Controller;

namespace teste_react_web_api{
  [ApiController]
  [Route("api/[controller]")]
  public class Professor : ControllerBase
  {
    [HttpGet]
    public IEnumerable<Professor> get(){
      return new Professor[]{
        new Professor{Id = 1, Nome = "Prof1"},
        new Professor{Id = 2, Nome = "Prof2"}
      }
    }
  }
}