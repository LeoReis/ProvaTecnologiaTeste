namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulaFaixa : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Faixas (nome,grau) VALUES ('Laranja','1')");
            Sql("INSERT INTO Faixas (nome,grau) VALUES ('Azul','2')");
            Sql("INSERT INTO Faixas (nome,grau) VALUES ('Rosa','3')");
            Sql("INSERT INTO Faixas (nome,grau) VALUES ('Verde','4')");
            Sql("INSERT INTO Faixas (nome,grau) VALUES ('Preta','5')");
        
    }
        
        public override void Down()
        {
        }
    }
}
