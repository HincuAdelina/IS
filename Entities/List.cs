using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkIT.Entities
{
    public class List
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int GroupId { get; set; } //FK
        public Group Group { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
