// See https://aka.ms/new-console-template for more information
using akasia_core;
using akasia_core.models;

Console.WriteLine("Hello, World!");

using var db = new CourseContext();
db.Initialize();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");


var query = (from attendance in db.Attendances
             join student in db.Students on attendance.NIM equals student.NIM
             where attendance.Date == DateTime.Parse("2020-06-15") || attendance.Date == DateTime.Parse("2020-06-17")
             select new { attendance.Date, attendance.NIM, student.Fullname })
            .Distinct().OrderBy(x => x.Date);


foreach (var q in query)
{
    Console.WriteLine($"DATE:{q.Date}, NIM: {q.NIM}, Fullname: {q.Fullname}");
}
Console.WriteLine();

var sqlStatement = query.ToString();
Console.WriteLine("Generated SQL Statement: " + sqlStatement);

var result = db.Attendances
            .GroupBy(a => a.Date)
            .Select(g => new
            {
                Date = g.Key,
                DistinctCount = g
            .Select(a => a.NIM).Distinct().Count()
            });

foreach (var item in result)
{
    Console.WriteLine($"Date: {item.Date}, Distinct Attendances: {item.DistinctCount}");
}


List<KawanLamaJewel> jewels = new List<KawanLamaJewel>
{
    new KawanLamaJewel { JewelType = JewelType.Ruby, Quantity = 5},
    new KawanLamaJewel { JewelType = JewelType.Topaz, Quantity = 3},
    new KawanLamaJewel { JewelType = JewelType.Permata, Quantity = 1}
};

 var jewelPairPrices = new Dictionary<JewelType, decimal>
        {
            { JewelType.Ruby, 1000000 },
            { JewelType.Topaz, 1250000 },
            { JewelType.Permata, 3000000 }
        };

decimal maximumIncome = jewels.CalculateMaximumIncome(jewelPairPrices);
Console.WriteLine($"Maximum Income: {maximumIncome}");