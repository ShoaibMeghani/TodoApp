using System.Collections.Generic; 

namespace TodoApp.Models{

    public class User{

        public long UserId { get; set; }
        
        public string Name { get; set; }
        
        public List<Todo> todoList { get; set;}
    }
}