using System;
using System.ComponentModel;

namespace Rocky.Models
{
    public class Category
    {
        [DisplayName("Category Id")]
        public int Id { get; set; }
        [DisplayName("Category Name")]
        public string Name { get; set; }
    }
}
