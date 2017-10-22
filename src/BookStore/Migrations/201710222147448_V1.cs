namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DataPedido = c.DateTime(nullable: false),
                        DataEnvio = c.DateTime(name: "Data Envio", nullable: false),
                        DataEntrega = c.DateTime(name: "Data Entrega", nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PedidoProduto",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedido", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 150),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category_Id = c.Int(nullable: false),
                        ProductOrder_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.PedidoProduto", t => t.ProductOrder_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.ProductOrder_Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 150),
                        Senha = c.String(nullable: false, maxLength: 15),
                        Registro = c.DateTime(nullable: false),
                        Ativacao = c.Boolean(nullable: false),
                        Codigo = c.Guid(nullable: false),
                        ConfirmPassword = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedido", "Id", "dbo.Usuario");
            DropForeignKey("dbo.Produto", "ProductOrder_Id", "dbo.PedidoProduto");
            DropForeignKey("dbo.Produto", "Category_Id", "dbo.Categoria");
            DropForeignKey("dbo.PedidoProduto", "Id", "dbo.Pedido");
            DropIndex("dbo.Produto", new[] { "ProductOrder_Id" });
            DropIndex("dbo.Produto", new[] { "Category_Id" });
            DropIndex("dbo.PedidoProduto", new[] { "Id" });
            DropIndex("dbo.Pedido", new[] { "Id" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Produto");
            DropTable("dbo.PedidoProduto");
            DropTable("dbo.Pedido");
            DropTable("dbo.Categoria");
        }
    }
}
