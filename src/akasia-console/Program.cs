// See https://aka.ms/new-console-template for more information
using akasia_core.models;

Console.WriteLine("Hello, World!");

using var db = new CourseContext();
db.Initialize();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// foreach (var item in db.Students)
// {
//     Console.WriteLine(item.NIM);
// }

var query = (from attendance in db.Attendances
             join student in db.Students on attendance.NIM equals student.NIM
             where attendance.Date == DateTime.Parse("2020-06-15") || attendance.Date == DateTime.Parse("2020-06-17")
             select new { attendance.Date ,attendance.NIM, student.Fullname })
            .Distinct().OrderBy(x => x.Date);


foreach (var result in query)
{
    Console.WriteLine($"DATE:{result.Date}, NIM: {result.NIM}, Fullname: {result.Fullname}");
}
Console.WriteLine();

// var sqlStatement = query.ToString();
// Console.WriteLine("Generated SQL Statement: {SqlStatement}", sqlStatement);

 var sqlStatement = query.ToString();
Console.WriteLine("Generated SQL Statement: " + sqlStatement);


