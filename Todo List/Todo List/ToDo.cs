using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_List
{
    public class ToDo
    {
        public virtual int Id { get; set; }
        public virtual string TaskName { get; set; }
        public virtual string TaskDescription { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
    }
}
