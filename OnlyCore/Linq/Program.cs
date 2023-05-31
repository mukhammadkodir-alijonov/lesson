using System.Collections;

namespace Linq;

public class Program
{
    private static IList<Person> People = new List<Person>()
    {
        new Person()
        {
            FirstName = "Muhammad",
            LastName = "alijonov",
            Address = "Namangan",
            Age = 20,
            PhoneNumber = "+998945040608",
            Job = "Developer"
        },
        new Person()
        {
            FirstName = "Qahhor",
            LastName = "Xurramov",
            Address = "Surxandaryo",
            Age = 21,
            PhoneNumber = "+998935040448",
            Job = "Waiter"
        },
        new Person()
        {
            FirstName = "Asror",
            LastName = "Abdullayev",
            Address = "Namangan",
            Age = 22,
            PhoneNumber = "+998945040341",
            Job = "Scientest"
        }

    };
    static void Main(string[] args)
    {
        /*//string[] arr = { "salom", "hayir", "muhammad", "avaz", "guli"};
        //arr = arr.OrderByDescending(x => x).ToArray();
        //foreach (string s in arr)
        //{
        //    Console.WriteLine(s);
        //}

        //string[] arr = { "salom", "hayir", "muhammad", "avaz", "guli" };

        //var arr2 = from item in arr
        //           where item.Contains("m")
        //           select item;
        //foreach (var item in arr2)
        //{
        //    Console.WriteLine(item);
        //}*/

        /*var ucellPhone = People.Where(x => (x.PhoneNumber.StartsWith("+99894") 
        || x.PhoneNumber.StartsWith("+99893" )) && x.Age == 20);

        foreach (var person in ucellPhone)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName);
        }*/

        //ArrayList arrayList = new ArrayList();
        //arrayList.Add(1);
        //arrayList.Add(2);
        //arrayList.Add(3);
        //arrayList.Add(4);
        //arrayList.Add(5);
        //arrayList.Add(true);
        //arrayList.Add("salom");
        //arrayList.Add("dunyo");
        //arrayList.Add("Muhammad");
        //arrayList.Add(10);
        //arrayList.Add(13);

        //var query = from human in People
        //            orderby human.Age descending
        //            select human;
        //foreach (var human in query)
        //{
        //    Console.WriteLine($"{human.LastName} {human.FirstName}");
        //} 



        //var query = People.OrderBy(x => x.FirstName)
        //    .ThenByDescending(x => x.Age);

        //foreach (var person in query)
        //    Console.WriteLine(person.FirstName + " " + person.Age);



        //var humans  = People.GroupBy(x => x.Job);
        //foreach (var groupHuman in humans)
        //{
        //    Console.WriteLine($"/----> {groupHuman.Key} - {groupHuman.Count()}");
        //    foreach(var human in groupHuman)
        //    {
        //        Console.WriteLine($"{human.FirstName} {human.LastName}");
        //    }
        //}




    }
}
public class Person
{
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Address { get; set; } = String.Empty;
    public int Age { get; set; }
    public string PhoneNumber { get; set; } = String.Empty;
    public string Job { get; set; } = String.Empty;  
}