namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulaAlunos : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Alunoes (nome,cpf) VALUES ('Leonardo','123456879')");
            Sql("INSERT INTO Alunoes (nome,cpf) VALUES ('Pedro','123456879')");
            Sql("INSERT INTO Alunoes (nome,cpf) VALUES ('Carlos','123456879')");
            Sql("INSERT INTO Alunoes (nome,cpf) VALUES ('Antonio','123456879')");
            Sql("INSERT INTO Alunoes (nome,cpf) VALUES ('Alberto','123456879')");
        }
        
        public override void Down()
        {
        }
    }
}
