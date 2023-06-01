namespace todo
{
      public record class ItemDTO
      {
            public int Id { get; set; }
            public string Name { get; set;} = String.Empty;
            public bool Done { get; set; }
      }
}

