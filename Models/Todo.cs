using System.ComponentModel.DataAnnotations;

namespace MeuTodo.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
    }
}