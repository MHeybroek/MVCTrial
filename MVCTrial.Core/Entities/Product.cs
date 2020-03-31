using MVCTrial_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCTrial_Core.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get ; set; }
        public float Price { get; set; }

    }
}
