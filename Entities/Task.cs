using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkIT.Entities
{
    public class Task

    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Reminder { get; set; }

        public string Important { get; set; }

        public List List { get; set; }//FK


    }
}
