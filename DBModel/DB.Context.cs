﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBContainer : DbContext
    {
        public DBContainer()
            : base("name=DBContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TransferBill> TransferBill { get; set; }
        public virtual DbSet<BackInput> BackInput { get; set; }
        public virtual DbSet<OtherInput> OtherInput { get; set; }
        public virtual DbSet<DIYBill> DIYBill { get; set; }
        public virtual DbSet<LocationChange> LocationChange { get; set; }
        public virtual DbSet<CheckBill> CheckBill { get; set; }
        public virtual DbSet<GiveBill> GiveBill { get; set; }
        public virtual DbSet<BackOutput> BackOutput { get; set; }
        public virtual DbSet<OtherOutput> OtherOutput { get; set; }
        public virtual DbSet<Record> Record { get; set; }
        public virtual DbSet<MenuA> MenuA { get; set; }
        public virtual DbSet<MenuB> MenuB { get; set; }
        public virtual DbSet<InWarehouse> InWarehouse { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<TaskBill> TaskBill { get; set; }
        public virtual DbSet<GoodItem> GoodItem { get; set; }
    }
}
