using System;
using System.ComponentModel.DataAnnotations;

namespace Task_IEatAsparagus.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateTime { get; set; }
        public int Count { get; set; }
    }
}