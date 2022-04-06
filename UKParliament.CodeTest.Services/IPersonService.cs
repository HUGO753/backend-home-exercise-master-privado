using System;
using System.Threading.Tasks;
using UKParliament.CodeTest.Services.Models;

namespace UKParliament.CodeTest.Services
{
    public interface IPersonService
    {
        Task<PersonInfo> GetAsync(int personId);
        Task<PersonInfo> GetName(string Name);
        Task<PersonInfo> GetDate(DateTime personBirth);

    }
    public class PersonService : IPersonService
    {
        private readonly System.Collections.Generic.List<PersonInfo> PersonInfo = new System.Collections.Generic.List<PersonInfo>()
        {
            new PersonInfo { Id = 0, Name = "Teste", DateOfBirth = Convert.ToDateTime("04/06/2021") },
            new PersonInfo { Id = 1, Name = "Teste2", DateOfBirth = Convert.ToDateTime("01/02/2022") },
            new PersonInfo { Id = 2, Name = "Teste3", DateOfBirth = Convert.ToDateTime("12/09/2021") },
            new PersonInfo { Id = 3, Name = "Teste4", DateOfBirth = Convert.ToDateTime("09/07/2020") }
        };
        public PersonService()
        {
            
        }
        // GET id
        public async Task<PersonInfo> GetAsync(int personId)
        {
            var iperson = PersonInfo.Find(PersonInfo => PersonInfo.Id == personId);
            return iperson;
        }
        // GET name
        public async Task<PersonInfo> GetName(string personName)
        {
            var nperson = PersonInfo.Find(PersonInfo => PersonInfo.Name == personName);
            return nperson;
        }
        // GET birth
        public async Task<PersonInfo> GetDate(DateTime personBirth)
        {
            var bperson = PersonInfo.Find(PersonInfo => PersonInfo.DateOfBirth == personBirth);
            return bperson;
        }

    }
}