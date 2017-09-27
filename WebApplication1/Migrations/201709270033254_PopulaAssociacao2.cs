namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulaAssociacao2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipoDeAssociacaos (nome,periodo,mensalidade) VALUES ('normal2',1,100)");
            Sql("INSERT INTO TipoDeAssociacaos (nome,periodo,mensalidade) VALUES ('Premium2',2,200)");
        }

        public override void Down()
        {
        }
    }
}
