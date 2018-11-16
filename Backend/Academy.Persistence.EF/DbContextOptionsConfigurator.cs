using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Persistence.EF
{
    public static class DbContextOptionsConfigurator
    {
        public static void ConfigForAcademy(this DbContextOptionsBuilder builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}
