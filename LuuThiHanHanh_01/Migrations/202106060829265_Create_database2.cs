namespace LuuThiHanHanh_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_database2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LopHocs", "TenLop", c => c.String(maxLength: 50));
            DropColumn("dbo.LopHocs", "LenLop");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LopHocs", "LenLop", c => c.String(maxLength: 50));
            DropColumn("dbo.LopHocs", "TenLop");
        }
    }
}
