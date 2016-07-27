namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWrPesquisa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WrPesquisas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        DataPesquisa = c.DateTime(),
                        WrHotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WrPesquisas");
        }
    }
}
