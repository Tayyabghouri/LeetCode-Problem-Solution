using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace LeetCode
{
    public class LinqPractice
    {
        List<string> StudentName = new List<string>
        {
            "Sara Mills 24"  ,
            "Andrew Gibson 21",
            "Craig Ellis 19",
            "Steven Cole 35",
            "Andrew Carter 15"


        };
        List<string> Name = new List<string>
        {
            "Sara Gibson",
            "Andrew Gibson",
            "Craig Ellis",
            "Steven Cole",
            "Andrew Ellis"

        };

        List<string> EmailList = new List<string>
        {
        "Sara Mills smills @gmail.com",
        "Andrew Gibson agibson @abv.bg",
        "Craig Ellis cellis@cs.edu.gov",
        "Steven Cole themachine@abv.bg",
        "Andrew Carter ac147@gmail.com"
        };

        List<string> PhoneNumber = new List<string>
        {
        "Sara Mills 02435521",
        "Andrew Gibson 0895223344",
        "Craig Ellis +3592667710",
        "Steven Ce 313331",
        "Andrew rr +001234532"
     };
        List<string> ExcelentStudentList = new List<string> { 
        "Sara Mills 6 6 6 5",
        "Andrew Gibson 3 4 5 6",
        "Craig Ellis 4 2 3 4",
        "Steven Cole 5 6 5 5",
        "Andrew Carter 5 3 4 2"
        }; 
        List<string> EnrolledStudent = new List<string> {
            "554214 6 6 6 5",
            "653215 3 4 5 6",
            "156212 4 2 3 4",
            "324413 5 6 5 5",
            "134014 5 3 4 2" 
        };
        List<Person> peoples = new List<Person>
            {
            new Person(10, "Ivaylo Petrov"),
            new Person(3, "Stanimir Svilianov"),
            new Person(3, "Indje Kromidov"),
            new Person(4, "Irina Balabanova")
            };

        public List<string> GetStudentByPhoneNumber()
        {
            var emails = PhoneNumber.Where(x => x.Split(' ').Length > 2 && (x.Split(' ')[2].StartsWith("02") || x.Split(' ')[2].StartsWith("+3592"))).Select(x => x.Split(' ')[0] + " " + x.Split(' ')[1]).ToList();

            return emails;

        }
        public List<string> GetStudentByEmailDomain()
        {
            var emails = EmailList.Where(x => x.EndsWith("@gmail.com")).Select(x => string.Join(" ", x.Split(' ').Take(2))).ToList();
            return emails;
        }
         public List<string> GetExcelentStudent()
        {
            var studentGrade = ExcelentStudentList.Where(x => x.Contains("6")).Select(x => x.Split(' ')[0] +" " + x.Split(' ')[1]).ToList();
            return studentGrade;
        }
        public List<string> GetWeakStudent()
        {
            var weakStudents = ExcelentStudentList.Where(s => s.Split(' ').Count(part => int.TryParse(part, out int mark) && mark <= 3) >= 2).Select(x => x.Split(' ')[0] + " " + x.Split(' ')[1]).ToList();
            return weakStudents;
        }
        public List<string> GetStudentEnrolledYear()
        {
            //var enrolledStudent = EnrolledStudent.Where(s =>s.Split(' ')[0].Skip(4).Take(2).Contains("14") || s.Split(' ')[0].Skip(4).Take(2).Contains("15") && s.Split(' ').Count(part => int.TryParse(part, out int mark) && mark <= 3) >= 2).Select(x => string.Join(" ", x.Split(' '))).ToList();
            var enrolledStudent =  EnrolledStudent.Where(s => (s.Split(' ')[0].Skip(4).Take(2).SequenceEqual("14")) ||(s.Split(' ')[0].Skip(4).Take(2).SequenceEqual("15"))).Select(s =>string.Join(" ", s.Split(' ').Skip(1))) // Skip the 
            .ToList();

            return enrolledStudent;
        }
        
        public List<string> GetStudentByAscendingAndDescendingOrder()
        {
            var namesss = Name.OrderBy(x => x.Split(' ')[1]).ThenByDescending(x => x.Split(' ')[0]).ToList();
            return namesss;
        }
        public List<string> GetStudentByAge()
        {
            var test = StudentName.Where(x =>
            {
                int age = int.Parse(x.Split(' ')[2]);
                return age > 18 && age <= 24;
            }).ToList();
            //Select(x => x.Split(' ')[2]).Select(x => int.Parse(x) >= 18 && int.Parse(x) <= 24).ToList();

            return test;
        }

        public List<string> GetStudentFirstNameOfGroupTwo()
        {
            string[] names = Name.Where(x => x.Split(' ').Length >= 2).Select(
            name =>
            {
                var completename = name.Split(' ');
                string FirstName = completename[0];
                string LastName = completename[1];
                int comparison = string.Compare(FirstName, LastName);
                if (comparison < 0)
                {
                    return name;
                }
                else
                {
                    return null;
                }

            }).Where(x => x != null).ToArray();
            //foreach (var test in names)
            //{

            //        Console.WriteLine(names);

            //}


            //var student = StudentName.Where(a => a.Contains("2")).OrderBy(x => x.Split(' ')[0]).ToList();
            //student = student.Select(x => x.Replace(" 2", "")).ToList();

            return names.ToList();
        }


        public List<string> GetStudentNameLexicographically()
        {
            string[] names = Name.Where(x => x.Split(' ').Length >= 2)
                .Select(name =>
                {
                    var completename = name.Split(' ');
                    string firstName = completename[0];
                    string lastName = completename[1];
                    int comparison = string.Compare(firstName, lastName);
                    if (comparison < 0)
                    {
                        return name;
                    }
                    else
                    {
                        return null;
                    }
                })
                .Where(x => x != null)
                .ToArray();

            return names.ToList();
        }
        public List<string> GetNameByAsecdingGroup()
        {
            //var test = peoples.GroupBy(a=>a.groupBy).Select(a=>a).ToList();
            //var groupedPeople = peoples.GroupBy(a=>a.groupBy).OrderBy(a=>a.Key).ToList();
            //List<Person> flatList = test.SelectMany(group => group).OrderBy(a=>a.groupBy).ToList();
            //foreach (var group in groupedPeople)
            //{
            //    var groupNames = string.Join(", ", group.Select(p => p.Name)); // Concatenate names in each group
            //    result.Add($"{group.Key} - {groupNames}");
            //}

            //// Output result
            //foreach (var groupInfo in result)
            //{
            //    Console.WriteLine(groupInfo);
            //}

            var result = peoples
           .GroupBy(p => p.groupBy)  // Group people by the 'Group' field
           .OrderBy(g => g.Key)    // Order groups by group number in ascending order
           .Select(g => $"{g.Key} - {string.Join(", ", g.Select(p => p.Name))}") // Format each group
           .ToList();  // Convert to a list (you can skip this if not needed)

            // Print the result
            //foreach (var groupInfo in result)
            //{
            //    Console.WriteLine(groupInfo);
            //}
           
            return result;

        }



        }
}
