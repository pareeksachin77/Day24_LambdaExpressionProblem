using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionProblem
{
    internal class LambdaSample
    {
        public static void AddRecords(List<Person> ListPersonInCity)
        {
            ListPersonInCity.Add(new Person("203456876", "John", "12 main street newyork", 15));
            ListPersonInCity.Add(new Person("205356876", "Sam", "12 main street newyork", 17));
            ListPersonInCity.Add(new Person("103159376", "Smith", "12 main street newyork", 35));
            ListPersonInCity.Add(new Person("903456254", "Sam", "12 main street newyork", 45));
            ListPersonInCity.Add(new Person("254857243", "John", "12 main street newyork", 55));
            ListPersonInCity.Add(new Person("364587257", "Sue", "12 main street newyork", 65));
            ListPersonInCity.Add(new Person("725887258", "Mac", "12 main street newyork", 85));
            ListPersonInCity.Add(new Person("015587256", "Sam", "12 main street newyork", 95));

        }
        public static void Retrieving_TopTwo_Records_ForAge_LessThanSixty(List<Person> ListPersonInCity)
        {
            foreach (Person person in ListPersonInCity.FindAll(e => (e.Age < 60)).Take(2))
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public static void CheckingForTeenagerPerson(List<Person> ListPersonInCity)
        {
            foreach (Person person in ListPersonInCity.FindAll(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
            if (ListPersonInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("Yes, we some teenagers in the list");
            }
            else
            {
                Console.WriteLine("No, we don't have teenages in this list");
            }
        }
        public static void AllPersonAverageAge(List<Person> ListPersonInCity)
        {
            double Average = ListPersonInCity.Average(e => e.Age);
            Console.WriteLine("The average of all persons age is : " + Average);
        }
        public static void CheckNameExistOrNot(List<Person> ListPersonInCity)
        {
            if (ListPersonInCity.Exists(e => e.Name == "Sam"))
            {
                Console.WriteLine("Yes,A Persom having Name \"Sam\" exist in our list");
            }
        }
        public static void Skip_Records_ForAges_LessThan_Sixty(List<Person> ListPersonInCity)
        {
            foreach (Person person in ListPersonInCity.SkipWhile(e => (e.Age < 60)))
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        public static void Remove_Specific_Name_From_List(List<Person> ListPersonInCity)
        {
            var searchName = ListPersonInCity.Find(e => e.Name == "Sam");

            if (searchName != null)
            {
                ListPersonInCity.Remove(searchName);
            }
            foreach (Person person in ListPersonInCity)
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }

        }

    }
}
