using System;
using System.Collections.Generic;
using System.Text;

namespace BoardR
{
    class Board
    {
        private static List<BoardItem> items = new List<BoardItem>();

        public static int TotalItems { get => items.Count; }
        public static void AddItem(BoardItem item)
        {
            if (items.Contains(item))
            {
                throw new InvalidOperationException("Item already exists!");
            }
            items.Add(item);
        }
    }
}
