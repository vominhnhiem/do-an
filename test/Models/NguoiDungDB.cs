using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace test.Models
{
    public partial class NguoiDungDB : DbContext
    {
        public NguoiDungDB()
            : base("name=NguoiDungDB")
        {
        }

        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MaNguoiDung);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TK)
                .IsFixedLength();

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MK)
                .IsFixedLength();

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.HoTen)
                .IsFixedLength();

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TheThanhVien)
                .IsFixedLength();
        }
    }
}
