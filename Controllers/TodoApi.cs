using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [Route("api/services")]
    public class ApiController : Controller
    {
        private readonly TodoDbHelper _todoDbHelper;

        public ApiController(TodoDbHelper repo)
        {
            _todoDbHelper = repo;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Content("It worked!");
        }

        [HttpGet("getAllUsers")]
        public List<User> GetAllUsers()
        {
            return _todoDbHelper.GetUsers();
        }

        [HttpPost("addUser")]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user != null)
            {
                _todoDbHelper.AddUser(user);
                return Content(user.ToString(), "application/json");
            }
            return Content("User is null");
        }

        [HttpDelete("deleteUser/{id}")]
        public IActionResult deleteUser(long id)
        {
            _todoDbHelper.DeleteUser(id);

            return Content("Item deleted");
        }

        [HttpPut("editUser/{id}")]
        public IActionResult editUser(long id, [FromBody] User user)
        {
            _todoDbHelper.EditUser(id, user);

            return Content("Item updated");
        }

         [HttpGet("getAllTodos")]
        public List<Todo> GetAllTodos()
        {
            return _todoDbHelper.GetTodos();
        }

        [HttpPost("addTodo")]
        public IActionResult AddTodo([FromBody] Todo todo)
        {
            if (todo != null)
            {
                _todoDbHelper.AddTodo(todo);
                return Content(todo.ToString(), "application/json");
            }
            return Content("User is null");
        }

        [HttpDelete("deleteTodo/{id}")]
        public IActionResult deleteTodo(long id)
        {
            _todoDbHelper.DeleteTodo(id);

            return Content("Item deleted");
        }

        [HttpPut("editTodo/{id}")]
        public IActionResult editTodo(long id, [FromBody] Todo todo)
        {
            _todoDbHelper.EditTodo(id, todo);

            return Content("Item updated");
        }





    }
}