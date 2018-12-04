using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index(){
            // Obtener todo items desde db
            // Poner items en el modelo
            // Renderizar vista
            return View();
        }
    }
}