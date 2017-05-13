namespace TodoApp.Models{

    public class Todo{

        public long TodoId { get; set; }
        public long UserId {get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
    }
}