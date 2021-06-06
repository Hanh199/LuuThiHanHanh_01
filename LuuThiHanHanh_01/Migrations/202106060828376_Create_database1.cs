namespace LuuThiHanHanh_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_database1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sinhviens",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 20),
                        Hoten = c.String(maxLength: 50),
                        MaLop = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.MaSinhVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sinhviens");
        }
    }
}
