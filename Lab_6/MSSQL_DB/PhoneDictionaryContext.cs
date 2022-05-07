using PhoneDictionary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_DB
{
    class PhoneDictionaryContext : DbContext
    {
        public PhoneDictionaryContext(string connString) : base($"name={connString}")
        {
        }

        public virtual DbSet<Phone> Phones { get; set; }
    }
}
