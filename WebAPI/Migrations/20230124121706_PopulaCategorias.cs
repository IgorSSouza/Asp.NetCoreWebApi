using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Categorias(Nome,ImageUrl) values('Bebidas','bebidas.jpg')");
            mb.Sql("insert into Categorias(Nome,ImageUrl) values('Lanches','lanches.jpg')");
            mb.Sql("insert into Categorias(Nome,ImageUrl) values('Sobremesas','sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
        }
    }
}
