using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apinew.Context;
using apinew.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace apinew.Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly ListaTarefa _Context;
        public TarefaController(ListaTarefa context)
        {
            _Context = context;
        }
        [HttpGet("{PorID}")] //httpost
        public IActionResult ObterPorId(int id)
        {
            var Tarefa = _Context.Tarefas.Find(id);
            if(Tarefa == null)
                return NotFound();
            
            return Ok(Tarefa);
        }
        [HttpPut("{PorId}")]
        public IActionResult Atualizar(int id, Tarefa Tarefa)
        {
            var TarefaBanco = _Context.Tarefas.Find(id);

            if(TarefaBanco == null)
                return NotFound();

            TarefaBanco.Titulo = Tarefa.Titulo;
            TarefaBanco.Descricao = Tarefa.Descricao;
            TarefaBanco.Data = Tarefa.Data;

            _Context.Tarefas.Update(TarefaBanco);
            _Context.SaveChanges();
            return Ok(TarefaBanco);
    }
    [HttpDelete("{Porid}")]
        public IActionResult Delete(int id)
        {
        
        var Delete = _Context.Tarefas.Find(id);

        if(Delete == null)
            return NotFound();

        _Context.Tarefas.Remove(Delete);
        _Context.SaveChanges();
        return NoContent();
    }
    [HttpGet("{Titulo}")] //httpost
        public IActionResult ObterPorTitulo(string Titulo)
        {
            var Tarefa = _Context.Tarefas.Find(Titulo);
            if(Tarefa == null)
                return NotFound();
            
            return Ok(Tarefa);
}
    [HttpGet("{Data}")] //httpost
        public IActionResult ObterPorData(string Data)
        {
            var Tarefa = _Context.Tarefas.Find(Data);
            if(Tarefa == null)
                return NotFound();
            
            return Ok(Tarefa);
}
}
}