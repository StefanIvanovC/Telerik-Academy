using System;
using System.Collections.Generic;
using System.Text;

namespace BoardR
{
    class BoardItem
    {
        private string title;
        private DateTime dueDate;
        public Status status;
        private StringBuilder history;
        private bool isSet = false;
        public BoardItem(string title, DateTime time)
        {

            this.history = new StringBuilder();
            this.Title = title;
            this.DueDate = time;
            isSet = true;
            var log = new EventLog("Item created");
            history.AppendLine(log.ViewInfo() + ": " + this.ViewInfo());
        }

        public string Title
        {
            get => this.title;
            set
            {
                var oldTitle = title;
                if (value.Length < 5 || value.Length > 30)
                {
                    throw new InvalidOperationException("Title must be betwen 5 and 30 characters!");
                }
                this.title = value;
                var newTitle = value;
                if (isSet)
                {
                    var log = new EventLog($"Title changed from '{oldTitle}' to '{newTitle}");
                    history.AppendLine(log.ViewInfo());
                }

            }
        }

        public DateTime DueDate
        {
            get => this.dueDate;
            set
            {
                var oldDate = dueDate.ToString("dd-MM-yyyy");
                if (value < DateTime.Now)
                {
                    throw new InvalidOperationException("Due date must be latter than cureecnt moment");
                }
                // [20200125|14:13:33.1218]DueDate changed from '25-01-2020' to '25-01-2030'

                this.dueDate = value;

                if (isSet)
                {
                    var newDate = value.ToString("dd-MM-yyyy");
                    var log = new EventLog($"DueDate changed from '{oldDate}' to '{newDate}");
                    history.AppendLine(log.ViewInfo());
                }
            }

        }

        public Status Status
        {
            get => this.status;
        }

        public string ViewHistory()
        {
            return history.ToString();
        }

        public string RevertStatus()
        {
            
            if (status.ToString() == "Open")
            {
                var log1 = new EventLog("Can't revert, already at Open");
                history.AppendLine(log1.ViewInfo());
                return status.ToString();
            }
            var log = new EventLog($"Status changed from {status--.ToString()} to {status.ToString()}");
            history.AppendLine(log.ViewInfo());
            return status.ToString();
        }

        public void AdvanceStatus()
        {
            if (this.status.ToString() == "Verified")
            {
                var log1 = new EventLog("Can't advance, already at Verified");
                history.AppendLine(log1.ViewInfo());
                return;
            }
            var log = new EventLog($"Status changed from {status++.ToString()} to {status.ToString()}");
            history.AppendLine(log.ViewInfo());
            return;
        }

        public string ViewInfo()
        {
            var data = dueDate.ToString("dd-MM-yyyy");
            return $"'{this.title}', [{this.status}|{data}]";
        }
    }
}
