using System;
using System.Collections.Generic;
using System.Text;

namespace BoardR
{
    public class BoardItem
    {
        public string title;
        public DateTime dueDate;
        public Status status;

        // Should accept a title, a date and assign those to their respective field
        public BoardItem(string title, DateTime dueDate) // validation in constructor looks sus
        {
            if (title == null || title == "")
            {
                this.title = "Title cannot be empty!";
            }
            else if (title.Length < 5 || title.Length > 30) // [5, 30] ex
            {
                this.title = "Title shoud be longer than 5 symbols and less than 30 sybmols";
            }
            else
            {
                this.title = title;
            }

            if (dueDate < DateTime.Now)
            {
                Console.WriteLine("Date cannot be in the past!");
            }
            else
            {
                this.dueDate = dueDate;
            }
            this.status = 0;
        }

        // RevertStatus() - returns the status to a previous state - e.g. from Todo to Open, from Done to InProgress, etc (no effect if the status is Open)
        public string RevertStatus()
        {
            status--;
            return $"{status}";
        }

        // AdvanceStatus() - advances the status to a next state - e.g.from Open to Todo, from Done to Verified, etc(no effect if the status is Verified)
        public string AdvanceStatus()
        {
            status++;
            return $"{status}";
        }

        // ViewInfo() - returns information about the current BoardItem in format '{title}', [{status}|{dueDate(dd-MM-yyyy)")}]" (How to format date and time?)
        public string ViewInfo()
        {
            return $"{title}, [{status}|{dueDate.ToString("MMMM dd, yyyy")}]";
        }
    }
}
