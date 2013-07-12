using System;

namespace NancyTests
{
    public class TodoItem
    {
        public TodoItem()
        {

        }

        public TodoItem(string title, bool done)
        {
            this.Title = title;
            this.Done = done;
        }

        public int Id
        {
            get;
            set;
        }

        public String Title
        {
            get;
            set;
        }

        public Boolean Done
        {
            get;
            set;
        }
    }
}

