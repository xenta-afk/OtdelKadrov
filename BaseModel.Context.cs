﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtdelKadrov
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OtdelEntities : DbContext
    {
        private static OtdelEntities _context;

        public OtdelEntities()
            : base("name=OtdelEntities")
        {
        }

        public static OtdelEntities GetContext()
        {
            if (_context == null)
                _context = new OtdelEntities();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<document> documents { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<link> links { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
