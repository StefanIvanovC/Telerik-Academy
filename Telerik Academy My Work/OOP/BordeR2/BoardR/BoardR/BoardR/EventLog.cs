using System;
using System.Collections.Generic;
using System.Text;

namespace BoardR
{
    class EventLog
    {
        private string description;
        private DateTime time;


        public EventLog(string description)
        {
            time = DateTime.Now;
            this.Description = description;
        }

        public DateTime Time
        {
            get => this.time;
            set
            {
                time = value;
            }
        }

        public string Description
        {
            get => this.description;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value cannot be null.");
                }
                description = value;
            }
        }

        public string ViewInfo()
        {//[20200125|13:57:55.7525]Created task
            var timeOutp = time.ToString("[yyyyMMdd|HH:mm:ss.ffff]");
            return $"{timeOutp}{description}";
        }
    }
}
