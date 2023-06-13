using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace akasia_core.models;

public class CourseContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Attendance> Attendances { get; set; }

    public string DbPath { get; }

    public CourseContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "course.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options
            // .LogTo(Console.WriteLine)
            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            .UseSqlite($"Data Source={DbPath}");
}
