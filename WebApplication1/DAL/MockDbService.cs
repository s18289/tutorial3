﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student { IdStudent = 1, FirstName = "Jan", LastName = "Kowalski", IndexNumber = "s15236" },
                new Student { IdStudent = 2, FirstName = "Anna", LastName = "Malewski", IndexNumber = "s17945" },
                new Student { IdStudent = 3, FirstName = "Andrzej", LastName = "Kotowski", IndexNumber = "s13865" }
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
