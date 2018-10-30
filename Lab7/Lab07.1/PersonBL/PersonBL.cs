using Entities;
using System;
using System.Collections.Generic;

namespace PersonBL
{
    public class PersonBL
    {

        List<Person> persons = new List<Person>();
        public void Create(Person person)
        {
            if (string.IsNullOrEmpty(person.Name))
                throw new ArgumentException("Name cannot be empty");
            persons.Add(person);
        }
         /// <summary>
         /// Finds the one item with the right
         /// </summary>
         /// <param name="id"></param>
         /// <returns></returns>
        public Person GetById(int id)
        {
            foreach (var item in persons)
            {
                if (item.Id == id) return item;
            }
            return null;
        }
    }
}
