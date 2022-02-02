using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsoleRestCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }
        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44346/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                Console.WriteLine("POST");
                Person newPerson = new Person();
                Console.WriteLine("Introduce el nombre del empleado");
                newPerson.FirstName = Console.ReadLine();
                Console.WriteLine("Introduce el apellido del empleado");
                newPerson.LastName = Console.ReadLine();
                Console.WriteLine("Introduce el sueldo del empleado");
                newPerson.PayRate = Console.ReadLine();
                Console.WriteLine("Introduce fecha de comienzo del contrato");
                newPerson.StartDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Introduce fecha de fin del contrato");
                newPerson.EndDate = DateTime.Parse(Console.ReadLine());

                response = await client.PostAsJsonAsync("api/person", newPerson);
                if (response.IsSuccessStatusCode)
                {
                    Uri personUrl = response.Headers.Location;
                    Console.WriteLine(personUrl);

                    newPerson.PayRate = "998";
                    response = await client.PutAsJsonAsync(personUrl, newPerson);
                    //response = await client.DeleteAsync(personUrl);

                }

                Console.WriteLine("GET");
                response = await client.GetAsync("api/person/6");
                if (response.IsSuccessStatusCode)
                {
                    Person person = await response.Content.ReadAsAsync<Person>();
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", person.FirstName, person.LastName, person.PayRate, person.StartDate, person.EndDate);
                    Console.ReadLine();
                }

                Console.WriteLine("GET ALL");
                response = await client.GetAsync("api/person/");
                if (response.IsSuccessStatusCode)
                {
                    List<Person> person = await response.Content.ReadAsAsync<List<Person>>();
                    for(int i=0;i<person.Count; i++)
                    {
                       Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", person[i].FirstName, person[i].LastName, person[i].PayRate, person[i].StartDate, person[i].EndDate);
                    }
                    Console.ReadLine();
                }

            }
        }
    }
}
