using System;
using System.Collections.Generic;
//Collections: List (add, forEach, find, count, contains), Dictionary (foreach)
//LINQ where, firstOrDefault, select, sum, min, max
using System.Linq;
namespace collectionsAndLINQ
{
    class Student 
    {
        public string FirstName {get; set;}

        public string LastName {get; set;}

        public List<string> CurrentClasses {get; set;}
    }

    public class StudentReport 
    {
        public string FullName {get; set;}

        public int ClassCount {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> currentStudents = new List<Student>(){
                new Student() {
                   FirstName = "Mo",
                   LastName = "Silvera",
                   CurrentClasses = new List<string>(){
                       "Women's Studies", "Art History", "Vegetable Gardening"
                   }
               },
               
               new Student() {
                   FirstName = "Lissa",
                   LastName = "Goforth",
                   CurrentClasses = new List<string>(){
                       "Rugby", "Research Methods", "Statistics"
                   }
               },
               
               new Student() {
                   FirstName = "Aja",
                   LastName = "Washington",
                   CurrentClasses = new List<string>(){
                       "Beyonce Studies", "Wine Tasting", "Music Theory"
                   }
               }
            };

            IEnumerable<StudentReport> totalReports = currentStudents.Select(
                student => 
                new StudentReport{
                    FullName = $"{student.FirstName} {student.LastName}",
                    ClassCount = student.CurrentClasses.Count
                }
            );

            totalReports.ToList().ForEach(report => Console.WriteLine($"{report.FullName} is taking {report.ClassCount} classes"));


            // List<int> populationCount = new List<int>() {
            //     1, 234, 5432, 8, 987
            // }; 

            // populationCount.Add(98765);

        //     foreach ( int pop in populationCount)
        //     {
        //         Console.WriteLine($"The population count is {pop}");
        //     }
           
        //    populationCount.ForEach(pop => Console.WriteLine($"This was written with a fat arrow {pop}"));

            // int foundNumber = populationCount.Find(num => num == 1);
            // Console.WriteLine($"Look what I found! {foundNumber}");
            // int firstMatch = populationCount.Find(num => num > 1); 
            // Console.WriteLine($"First number greater than one is {firstMatch}");

            // int lengthOfList = populationCount.Count;
            // Console.WriteLine(lengthOfList);
            
            // bool doesItHaveTwo = populationCount.Contains(2);

            // Console.WriteLine($"Does the list contain 2? {doesItHaveTwo}");

            // Dictionary<string,int> populationDictionary =  new Dictionary<string, int>(){
            //     {"Townsville", 344},
            //     {"New Haven", 222},
            //     {"Smyrna", 4}
            // };

            // populationDictionary.Add("Kingston", 3000);

            // Console.WriteLine(populationDictionary);

            // foreach (KeyValuePair<string, int> town in populationDictionary)
            // {
            //     Console.WriteLine($"{town.Key} has a population of {town.Value}");
            // }

            // int dictionaryCount = populationDictionary.Count;

            // Console.WriteLine($"What is this? {dictionaryCount}");

        //    IEnumerable<int> tinyTowns= populationCount.Where(population => population< 200); 

            // tinyTowns.ToList().ForEach(pop => Console.WriteLine($"The population of this tiny town is {pop}"));

            // List<double> countWithDoubles = new List<double> (){
            //     1.2, 3.4, 5.7, 2345.88
            // };

            // double partialPeople = countWithDoubles.Sum();

            // int smallestTownPop = populationCount.Min();
            // int largestTownPop = populationCount.Max();
            // int totalStatePop = populationCount.Sum();

            // Console.WriteLine($"The smallest population is {smallestTownPop}");
            // Console.WriteLine($"The largest population is {largestTownPop}");
            // Console.WriteLine($"The total state population is {totalStatePop}");
            // Console.WriteLine($"Did this work? {partialPeople}");

            // int greaterThanOne = populationCount.FirstOrDefault(pop => pop > 1);

            // Console.WriteLine($"The first population greater than one is {greaterThanOne}");

            // IEnumerable<int> populationSquared = populationCount.Select(population => population * population); 

            // populationSquared.ToList().ForEach(num => Console.WriteLine($"This is the population squared {num}"));





        }
    }
}
