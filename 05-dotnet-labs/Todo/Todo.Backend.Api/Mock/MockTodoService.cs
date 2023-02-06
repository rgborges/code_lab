using Todo.Backend.Api.Models;


namespace Todo.Backend.Api.Mock   
{
      public static class MockTodoService
      {
            public static List<DTOTodoItem> GenTodoItemSampleDB() 
            {
                  var result = new List<DTOTodoItem>();
                  string[] itens = new[] { 
                        "Get the trash out",
                        "Do my home work",
                        "Try something new",
                        "Get a new music in my repertory",
                        "Game Froza Horizon"
                  };
                  try
                  {

                        
                        for (int i = 0; i < itens.Length; i++)
                        {
                              result.Add(new DTOTodoItem{
                                    Id = i,
                                    Name = itens[i],
                                    Done = false
                              });
                        }
                        return result.List<DTOTodoItem>();
                  }
                  catch
                  {
                        throw;
                  }
            }
      }
}