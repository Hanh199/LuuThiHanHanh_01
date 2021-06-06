namespace LuuThiHanHanh_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        LenLop = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHocs");
        }
    }
}
