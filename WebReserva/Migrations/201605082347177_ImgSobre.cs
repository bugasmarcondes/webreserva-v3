namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImgSobre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrHotels", "ImgSobre01", c => c.String());
            AddColumn("dbo.WrHotels", "ImgSobre02", c => c.String());
            AddColumn("dbo.WrHotels", "ImgSobre03", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WrHotels", "ImgSobre03");
            DropColumn("dbo.WrHotels", "ImgSobre02");
            DropColumn("dbo.WrHotels", "ImgSobre01");
        }
    }
}
