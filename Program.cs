var students = new List<Student>
{
     new Student { Id = 1, FirstName = "Cristiano", LastName = "Roni", Age = 15, Gender = "Female", Status = "Active", DateOfStart = new DateTime(2023, 9, 1), DateOfFinish = new DateTime(2026, 6, 30) },
     new Student { Id = 2, FirstName = "Leo", LastName = "Messi", Age = 27, Gender = "Male", Status ="InActive", DateOfStart = new DateTime(2019, 9, 1), DateOfFinish = new DateTime(2023, 6, 30) },
     new Student { Id = 3, FirstName = "Adrien", LastName = "Rabiot", Age = 18, Gender = "Male", Status = "Active", DateOfStart = new DateTime(2021, 9, 1), DateOfFinish = new DateTime(2024, 6, 30) },
     new Student { Id = 4, FirstName = "Connor", LastName = "Mcgregor", Age = 32, Gender = "Male", Status = "Active", DateOfStart = new DateTime(2020, 9, 1), DateOfFinish = new DateTime(2024, 6, 30) },
     new Student { Id = 5, FirstName = "Neymar", LastName = "Jr", Age = 25, Gender = "Male", Status = "Active", DateOfStart = new DateTime(2023, 9, 1), DateOfFinish = new DateTime(2027, 6, 30) },
     new Student { Id = 6, FirstName = "Charles", LastName = "Oliveira", Age = 29, Gender = "Female", Status = "InActive", DateOfStart = new DateTime(2018, 9, 1), DateOfFinish = new DateTime(2022, 6, 30) }
};
task1
var maleStudents = students.Where(s => s.Gender == "Male");

Console.WriteLine("Task 1: Male Students:");
foreach (var student in maleStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}");
}


task2

 var inactiveStudents = students.Where(s => s.Status == "InActive");
Console.WriteLine("\nTask 2: Inactive Students:");
foreach (var s in inactiveStudents){
 Console.WriteLine($"{s.FirstName} {s.LastName}");}


task3

 var bornAfter2000 = students.Where(s => (DateTime.Now.Year - s.Age) > 2000);
 Console.WriteLine("Task 3: Born after 2000:");
 foreach (var s in bornAfter2000){
  Console.WriteLine($"{s.FirstName} {s.LastName} - Year: {DateTime.Now.Year - s.Age}");}

task 4


 var o = students.Where(s => s.Age > 20 && s.DateOfFinish > DateTime.Now);
Console.WriteLine("Task 4: Over 20 and still studying:");
foreach (var s in o){
Console.WriteLine($"{s.FirstName} {s.LastName}, Age: {s.Age}");}


task5

 var startedAt16 = students.Where(s => s.DateOfStart.Year - (DateTime.Now.Year - s.Age) == 16);
 Console.WriteLine("Task 5: Started studying at 16:");
foreach (var s in startedAt16){
Console.WriteLine($"{s.FirstName} {s.LastName}");}

task6

 var startedAsAdult = students.Where(s => s.DateOfStart.Year - (DateTime.Now.Year - s.Age) >= 18);
 Console.WriteLine("\nTask 6: Started when 18+:");
  foreach (var s in startedAsAdult){
  Console.WriteLine($"{s.FirstName} {s.LastName}");}

task7


var startsWithAorI = students.Where(s => s.FirstName.StartsWith("A") || s.FirstName.StartsWith("I"));
Console.WriteLine("Task 7: FirstName starts with A or I:");
foreach (var s in startsWithAorI){
Console.WriteLine($"{s.FirstName} {s.LastName}");}


// task 8
 var sameFirstLast = students.Where(s => s.FirstName[0] == s.LastName[0]);
Console.WriteLine("Task 8: First and LastName start with same letter:");
foreach (var s in sameFirstLast){
 Console.WriteLine($"{s.FirstName} {s.LastName}");}


task 9

var becameAdultWhileStudying = students.Where(s =>
{
            var yearOfBirth = DateTime.Now.Year - s.Age;
            var yearOf18 = yearOfBirth + 18;
            return yearOf18 >= s.DateOfStart.Year && yearOf18 <= s.DateOfFinish.Year;
});
 Console.WriteLine("\nTask 9: Became adult during study:");
 foreach (var s in becameAdultWhileStudying){
 Console.WriteLine($"{s.FirstName} {s.LastName}");}
