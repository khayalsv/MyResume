using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.Data.Entities
{
    public class Home : BaseEntity<int>
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }


}
