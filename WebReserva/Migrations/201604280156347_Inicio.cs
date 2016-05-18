namespace WebReserva.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WrBloqueioDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Inicio = c.DateTime(nullable: false),
                        Fim = c.DateTime(nullable: false),
                        Descricao = c.String(),
                        Mensagem = c.String(),
                        Pacote = c.Boolean(nullable: false),
                        WrHotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WrDisponibilidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        ValorDiaria = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WrTipoApartamentoId = c.Int(nullable: false),
                        DiariaAdulto01 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaAdulto02 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaAdulto03 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaAdulto04 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaAdulto05 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaAdulto06 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaAdulto07 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaAdulto08 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaAdulto09 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaAdulto10 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca00 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca01 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca02 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca03 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca04 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca05 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca06 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca07 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca08 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca09 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca10 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca13 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca14 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca15 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca16 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiariaCrianca17 = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WrTipoApartamentoes", t => t.WrTipoApartamentoId, cascadeDelete: true)
                .Index(t => t.WrTipoApartamentoId);
            
            CreateTable(
                "dbo.WrTipoApartamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Descricao = c.String(maxLength: 300),
                        Img01 = c.String(maxLength: 1000),
                        Img02 = c.String(maxLength: 1000),
                        Img03 = c.String(maxLength: 1000),
                        DestaqueTitulo = c.String(maxLength: 100),
                        DestaqueDescricao = c.String(unicode: false, storeType: "text"),
                        OpcionalTitulo01 = c.String(maxLength: 100),
                        OpcionalDescricao01 = c.String(unicode: false, storeType: "text"),
                        OpcionalTitulo02 = c.String(maxLength: 100),
                        OpcionalDescricao02 = c.String(unicode: false, storeType: "text"),
                        OpcionalTitulo03 = c.String(maxLength: 100),
                        OpcionalDescricao03 = c.String(unicode: false, storeType: "text"),
                        IdLetoh = c.Int(nullable: false),
                        WrHotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WrHotels", t => t.WrHotelId, cascadeDelete: true)
                .Index(t => t.WrHotelId);
            
            CreateTable(
                "dbo.WrReservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        Adulto = c.Int(nullable: false),
                        Chd = c.Int(),
                        QtdUh = c.Int(nullable: false),
                        Observacao = c.String(),
                        IdLetoh = c.Int(),
                        DataIntegra = c.DateTime(),
                        Nome = c.String(),
                        Email = c.String(),
                        Telefone = c.String(),
                        Cpf = c.String(),
                        ApartamentoNomeHospede = c.String(),
                        Chegada = c.DateTime(nullable: false),
                        Saida = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        WrTipoApartamento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WrTipoApartamentoes", t => t.WrTipoApartamento_Id)
                .Index(t => t.WrTipoApartamento_Id);
            
            CreateTable(
                "dbo.WrHotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Descricao = c.String(),
                        ImgLogo = c.String(),
                        HostUrl = c.String(),
                        Tema = c.String(),
                        MaxAdultos = c.Int(),
                        MaxCriancas = c.Int(),
                        EmailAdministrador = c.String(),
                        MsgCustomizadaEmail = c.String(),
                        Default = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WrTipoApartamentoes", "WrHotelId", "dbo.WrHotels");
            DropForeignKey("dbo.WrReservas", "WrTipoApartamento_Id", "dbo.WrTipoApartamentoes");
            DropForeignKey("dbo.WrDisponibilidades", "WrTipoApartamentoId", "dbo.WrTipoApartamentoes");
            DropIndex("dbo.WrReservas", new[] { "WrTipoApartamento_Id" });
            DropIndex("dbo.WrTipoApartamentoes", new[] { "WrHotelId" });
            DropIndex("dbo.WrDisponibilidades", new[] { "WrTipoApartamentoId" });
            DropTable("dbo.WrHotels");
            DropTable("dbo.WrReservas");
            DropTable("dbo.WrTipoApartamentoes");
            DropTable("dbo.WrDisponibilidades");
            DropTable("dbo.WrBloqueioDatas");
        }
    }
}
