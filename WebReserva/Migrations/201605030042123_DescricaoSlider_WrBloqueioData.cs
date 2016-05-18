namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescricaoSlider_WrBloqueioData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WrBloqueioDatas", "DescricaoSlider", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WrBloqueioDatas", "DescricaoSlider");
        }
    }
}
