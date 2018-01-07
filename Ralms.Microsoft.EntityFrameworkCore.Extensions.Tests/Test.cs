using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Ralms.Microsoft.EntityFrameworkCore.Tests
{
    public class Test
    {
        private SampleContext db;
        private List<People> peopleList = null;

        public Test()
        {
            db = new SampleContext();
            peopleList = new List<People>();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            for (int i = 0; i < 100; i++)
            {
                peopleList.Add(new People
                {
                    Name = $"Teste {i}",
                    Birthday = DateTime.Now.AddDays(i)
                });
            }
        }

        [Fact]
        public void ClientEval()
        {
            var list = peopleList
                .Where(p => EFCore.DateDiff(DatePart.day, DateTime.Now, p.Birthday) < 50)
                .ToList();

            Assert.True(list.Count == 50);
        }

        [Fact]
        public void ServerTranslate()
        {
            db.People.AddRange(peopleList);
            db.SaveChanges();

            var list = db
                .People
                .Where(p => EFCore.DateDiff(DatePart.day, DateTime.Now, p.Birthday) < 50)
                .ToList();

            Assert.True(list.Count == 50);
        }
    }
}
