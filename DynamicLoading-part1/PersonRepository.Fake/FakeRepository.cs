using PersonRepository.Interface;
using System;
using System.Collections.Generic;

namespace PersonRepository.Fake
{
    public class FakeRepository : IPersonReader
    {
        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>
            {
                new Person
                {
                     FamilyName = "Noorani",
                     GivenName = "Ashique",
                     Id = 1,
                     Rating = 7,
                     StartDate = new DateTime(1992,01,01)
                },
                new Person
                {
                     FamilyName = "Mark",
                     GivenName = "Waush",
                     Id = 2,
                     Rating = 6,
                     StartDate = new DateTime(1982,01,01)
                }
            };

            return people;
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }
    }
}
