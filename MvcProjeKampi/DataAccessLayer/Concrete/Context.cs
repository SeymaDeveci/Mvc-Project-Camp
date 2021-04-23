using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext //DbContext sınıfına ait özellikler eklensin
    {
        public DbSet<About> Abouts { get; set; } //DbSet türünde proporty tanımlama.
                                                 //EntityLayer katmanındaki About sınıfına erişme.
                                                 //Abouts nedir? Veritabanındaki tablonun ismi.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
