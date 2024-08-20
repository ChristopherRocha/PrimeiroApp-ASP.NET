using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjetoGerenciarTarefas.Contexts;
using ProjetoGerenciarTarefas.Models;

namespace ProjetoGerenciarTarefas.Controllers
{
    public class aFazeresController : Controller
    {

        private readonly Contextos _contextos;

        public aFazeresController(Contextos contextos)
        {
            _contextos = contextos;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Lista de tarefas";
            var tmpTarefas = _contextos.aFazeres.ToList();
            return View(tmpTarefas);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Nova Tarefa";
            return View("Form");
        }

        [HttpPost]
        public IActionResult Create(ParaFazer tarefa)
        {
            if(ModelState.IsValid)
            {
            tarefa.DataCriacao = DateTime.Now;
            _contextos.aFazeres.Add(tarefa);
            _contextos.SaveChanges();
            return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["Title"] = "Nova Tarefa";
                return View("Form", tarefa);
            }
        }

        public IActionResult Edit(int id)
        {
            var tarefa = _contextos.aFazeres.Find(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            ViewData["Title"] = "Editar Tarefa";
            return View("Form", tarefa);

        }

        [HttpPost]
        public IActionResult Edit(ParaFazer tarefa)
        {

            if(ModelState.IsValid)
            {
                _contextos.aFazeres.Update(tarefa);
                _contextos.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["Title"] = "Editar Tarefa";
                return View("Form", tarefa);
            }
            
        
        }

        public IActionResult Delete(int id) 
        {
            var tarefa = _contextos.aFazeres.Find(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            ViewData["Title"] = "Excluir Tarefa";
            return View(tarefa);
        
        }

        [HttpPost]
        public IActionResult Delete(ParaFazer tarefa)
        {
            _contextos.aFazeres.Remove(tarefa);
            _contextos.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Finish(int id)
        {
            var tarefa = _contextos.aFazeres.Find(id);
            if(tarefa == null)
            {
                return NotFound();
            }

            tarefa.Finish();
            _contextos.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
