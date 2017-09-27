namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulaAssociacao : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipoDeAssociacaos (nome,periodo,mensalidade) VALUES ('normal',1,100)");
            Sql("INSERT INTO TipoDeAssociacaos (nome,periodo,mensalidade) VALUES ('Premium',2,200)");
            Sql("INSERT INTO TipoDeAssociacaos (nome,periodo,mensalidade) VALUES ('Ultra Mega Power',3,300)");
        }
        
        public override void Down()
        {
        }
    }
}
