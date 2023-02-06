namespace Todo.Backend.Api.Models
{
      public record DTOTodoItem
      {
            public int Id { get; set; }
            public string? Name { get; set; }
            public bool Done { get; set; }
      }
}