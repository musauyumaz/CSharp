//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class YemekTarifiEntities : DbContext
{
    public YemekTarifiEntities()
        : base("name=YemekTarifiEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Kategoriler> Kategoriler { get; set; }
    public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
    public virtual DbSet<Tarifler> Tarifler { get; set; }
    public virtual DbSet<Yorumlar> Yorumlar { get; set; }
    public virtual DbSet<Mesajlar> Mesajlar { get; set; }
    public virtual DbSet<Hakkimizdas> Hakkimizdas1 { get; set; }
    public virtual DbSet<Yemekler> Yemeklers { get; set; }
}
