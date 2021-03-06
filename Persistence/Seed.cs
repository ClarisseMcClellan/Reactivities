using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeddData(DataContext context)
        {
            if(context.Activities.Any())
            return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 month ago",
                    Category = "Drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Louvre",
                },
                new Activity 
                {
                    Title = "Future Activity 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "Culture",
                    City = "London",
                    Venue = "Natural History Museum",
                },
                new Activity 
                {
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity 2 month in future",
                    Category = "Music",
                    City = "London",
                    Venue = "02 Arena",
                },
                new Activity 
                {
                    Title = "Future Activity 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Activity 3 month in future",
                    Category = "Drinks",
                    City = "London",
                    Venue = "Another Pub",
                },
                new Activity 
                {
                    Title = "Future Activity 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Activity 4 month in future",
                    Category = "Drinks",
                    City = "London",
                    Venue = "Yet Another Pub",
                },
                new Activity 
                {
                    Title = "Future Activity 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Activity 5 month in future",
                    Category = "Drinks",
                    City = "London",
                    Venue = "Just Another Pub",
                },
                new Activity 
                {
                    Title = "Future Activity 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Activity 6 month in future",
                    Category = "Music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                },
                new Activity 
                {
                    Title = "Future Activity 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Activity 7 month in future",
                    Category = "Travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },
                new Activity 
                {
                    Title = "Future Activity 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Activity 8 month in future",
                    Category = "Film",
                    City = "London",
                    Venue = "Cinema",
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}