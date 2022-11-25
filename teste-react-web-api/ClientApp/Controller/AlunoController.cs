using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using teste_react_web_api.Controller;

namespace teste_react_web_api{
  [ApiController]
  [Route("api/[controller]")]
  public class AlunoController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<Aluno>> get(){
      return new Aluno[]{
        new Aluno{Id = 1, Nome = "Ana", Matricula = 123},
        new Aluno{Id = 2, Nome = "Joao", Matricula = 456}
      }
    }
  }
}