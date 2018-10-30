using System;

namespace Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int edad = Convert.ToInt32(today) - Convert.ToInt32(Birthday);
                return edad;
            }
        }
    }
}
