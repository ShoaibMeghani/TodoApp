using TodoApp.Data;
using TodoApp.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class TodoDbHelper
{
    private readonly TodoContext _context;

    public TodoDbHelper(TodoContext context)
    {
        _context = context;
    }

    // =======================CRUD for User================================
    public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public List<User> GetUsers()
    {
        return _context.Users.Include(u => u.todoList).ToList();
    }

    public void DeleteUser(long id)
    {
       var userItem = _context.Users.Where(user => user.UserId == id).FirstOrDefault();
       _context.Users.Remove(userItem);
       _context.SaveChanges();
    }

    public void EditUser(long id,User u)
    {
       var userItem = _context.Users.Where(user => user.UserId == id).FirstOrDefault();
       userItem.Name = u.Name;
       _context.SaveChanges();
    }

    // =======================CRUD for Todo================================
    public void AddTodo(Todo todo)
    {
        _context.Todos.Add(todo);
        _context.SaveChanges();
    }

    public List<Todo> GetTodos()
    {
        return _context.Todos.ToList();
    }

    public void DeleteTodo(long id)
    {
       var todoItem = _context.Todos.Where(todo => todo.TodoId == id).FirstOrDefault();
       _context.Todos.Remove(todoItem);
       _context.SaveChanges();
    }

    public void EditTodo(long id,Todo t)
    {
       var todoItem = _context.Todos.Where(todo => todo.TodoId == id).FirstOrDefault();
       todoItem.Title = t.Title;
       todoItem.Name = t.Name;
       todoItem.UserId = t.UserId;
       _context.SaveChanges();
    }
}