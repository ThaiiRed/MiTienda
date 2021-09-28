using Microsoft.EntityFrameworkCore;

namespace MiTienda.Data;
public class LojaContext : DbContext
{

    /*Criando uma Tabela que conterá um conjunto de DADOS/objetos do tipo Produto. Por isso a tabela se chama "Produtos"*/
    public DbSet<Produto> Produtos {  get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    public LojaContext(DbContextOptions<LojaContext> options) : base(options)
    {

    }
}
