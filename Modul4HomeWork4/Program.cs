// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Modul4HomeWork4.Data;
using Modul4HomeWork4.Data.Entities;

var context = new ApplicationDbContextFactory().CreateDbContext(args);
context.Locations.Add(new LocationEntity
{
    Location_Name = "Kharkiv"
});

await context.SaveChangesAsync();

var location = context.Locations.AsNoTracking().FirstOrDefault();
Console.Read();