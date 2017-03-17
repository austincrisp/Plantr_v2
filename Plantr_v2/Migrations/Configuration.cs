namespace Plantr_v2.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Plantr_v2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Plantr_v2.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Courses.AddOrUpdate(
                c => c.Title,
                new Course
                {
                    Title = "Bible Correspondence Course",
                    Description = "This first course will analyze the statement made in John 14:6."
                },
                new Course
                {
                    Title = "How's Your Hearing",
                    Description = "The second course outlines the hearing portion of the plan of salvation and discusses why it is important."
                },
                new Course
                {
                    Title = "Three Indespensables of Faith",
                    Description = "Course three will outline the believe portion of the plan of salvation and look at 3 specific elements for faith."
                },
                new Course
                {
                    Title = "The Most Difficult Command",
                    Description = "Course Four will discuss the repentance portion of the plan of salvation and look at 3 requirements for it."
                },
                new Course
                {
                    Title = "True Confessions",
                    Description = "Course Five will discuss the confession portion of the plan of salvation."
                },
                new Course
                {
                    Title = "They That Gladly Received His Word Were Baptized",
                    Description = "Course Six will discuss the baptism portion of the plan of salvation."
                },
                new Course
                {
                    Title = "Be Thou Faithful Unto Death",
                    Description = "Course Seven will discuss the final step in the plan of salvation, living a faithful life, after baptism, unto death."
                },
                new Course
                {
                    Title = "What God Wants To Do To Every Sinner",
                    Description = "Course Eight will discuss the aspects of God's love and forgiveness for all sinners."
                }
            );
        }
    }
}
