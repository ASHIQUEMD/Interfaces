using PersonRepository.Interface;
using System;
using System.Configuration;

namespace PersonRepository.Factory
{
    public static class RepositoryFactory
    {
        public static IPersonReader GetRepository()
        {
            string repositoryTypeName =
                ConfigurationManager.AppSettings["RepositoryType"];
            Type repositoryType = Type.GetType(repositoryTypeName);
            Object repository = Activator.CreateInstance(repositoryType);
            IPersonReader personRepository = repository as IPersonReader;

            return personRepository;
        }
    }
}
