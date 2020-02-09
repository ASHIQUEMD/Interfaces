
using Newtonsoft.Json;
using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Net;

namespace PersonRepository.Service
{
    public class ServiceRepository : IPersonRepository
    {
        WebClient client = new WebClient();
        string uri = "http://localhost:9874/api/people";
         
        public IEnumerable<Person> GetPeople()
        {
            var people = client.DownloadString(uri);
            return JsonConvert.DeserializeObject<IEnumerable<Person>>(people);
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }
    }
}
