namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        cpf = c.String(),
                        faixa_id = c.Int(),
                        tipo_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Faixas", t => t.faixa_id)
                .ForeignKey("dbo.TipoDeAssociacaos", t => t.tipo_id)
                .Index(t => t.faixa_id)
                .Index(t => t.tipo_id);
            
            CreateTable(
                "dbo.Faixas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        grau = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TipoDeAssociacaos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        periodo = c.Int(nullable: false),
                        mensalidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alunoes", "tipo_id", "dbo.TipoDeAssociacaos");
            DropForeignKey("dbo.Alunoes", "faixa_id", "dbo.Faixas");
            DropIndex("dbo.Alunoes", new[] { "tipo_id" });
            DropIndex("dbo.Alunoes", new[] { "faixa_id" });
            DropTable("dbo.TipoDeAssociacaos");
            DropTable("dbo.Faixas");
            DropTable("dbo.Alunoes");
        }
    }
}
