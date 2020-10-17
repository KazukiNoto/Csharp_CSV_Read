using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using WebApiCsv.Data;
using WebApiCsv.Models;

namespace Csharp_CSV_Read {
    class Program {
        static void Main (string[] args) {
            using (var reader = new StreamReader (location, Encoding.Default))
            using (var csv = new CsvReader (reader)) {
                csv.Configuration.RegisterClassMap<StudentMap> ();
                var records = csv.GetRecords<Student> ().ToList ();
                return records;
            }
        }
    }
}