using System;

namespace BoardR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test checked
            // var item = new BoardItem("Refactor this mess", DateTime.Now.AddDays(2));
            // item.AdvanceStatus();
            // var anotherItem = new BoardItem("Encrypt user data", DateTime.Now.AddDays(10));
            //
            // Board.items.Add(item);
            // Board.items.Add(anotherItem);
            //
            // foreach (var boardItem in Board.items)
            // {
            //     boardItem.AdvanceStatus();
            // }
            //
            // foreach (var boardItem in Board.items)
            // {
            //     Console.WriteLine(boardItem.ViewInfo());
            // }

            //Test checked
            // var item = new BoardItem("", DateTime.Now.AddDays(2));
            // Console.WriteLine(item.title); // Refactor this mess
            // Console.WriteLine(item.dueDate); // 25/01/2020 12:09:49 PM (this will vary depending on when you run the code)
            // Console.WriteLine(item.status); // Open

            //Test Cheked
            // var item = new BoardItem("Refactor this mess", DateTime.Now.AddDays(2));
            // Console.WriteLine(item.ViewInfo());
            // Console.WriteLine(item.status); // Open
            // item.AdvanceStatus();
            // Console.WriteLine(item.status); // Todo
            // item.AdvanceStatus();
            // Console.WriteLine(item.status); // InProgress
            // item.RevertStatus();
            // Console.WriteLine(item.status); // ToDo
            
        }
    }
}
