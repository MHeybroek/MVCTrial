using MVCTrial_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCTrial_Core.Entities
{
    public class Project: IEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Product> Products { get; set; }
    }

}
