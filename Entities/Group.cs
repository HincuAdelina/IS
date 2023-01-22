using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkIT.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; } //FK
        public User User { get; set; }

        public ICollection<List> Lists { get; set; }
    }
}
