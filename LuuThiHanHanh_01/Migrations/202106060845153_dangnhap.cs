namespace LuuThiHanHanh_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dangnhap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DangNhaps",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DangNhaps");
        }
    }
}
