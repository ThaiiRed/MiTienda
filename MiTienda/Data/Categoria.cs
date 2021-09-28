
using System.ComponentModel.DataAnnotations;

namespace MiTienda.Data;
public class Categoria
{
    public int Id {  get; set; }

    [StringLength(255)]
    public string? Descricao {  get; set; }

    public List<Produto> Produtos { get; set; }

}
