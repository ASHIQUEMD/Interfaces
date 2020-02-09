using PersonRepository.Interface;
using PersonRepository.Service;
using System;

namespace PersonRepository.Factory
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository(string assemblyType)
        {
            try
            {
                var t = typeof(ServiceRepository);
                return (IPersonRepository)Activator.CreateInstance(
                   Type.GetType($"PersonRepository.{assemblyType}.{assemblyType}Repository, PersonRepository.{assemblyType}"));
            }
            catch(Exception ex)
            {
                throw new Exception("Unknown repository", ex);
            }
        }
    }
}
