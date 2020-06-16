using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppMonoWeb.Data
{
    public class AppMonoContext : IdentityDbContext
    {
        public AppMonoContext(DbContextOptions<AppMonoContext> options)
            : base(options)
        {
        }
    }
}
