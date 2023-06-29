using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoLipa.Models;

public partial class ItemVenda
{
    public int Id { get; set; }

    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; } = null!;

    [ForeignKey("VendaId")]
    public Venda? Venda { get; set; }

    public int VendaId { get; set; }

    public int ProdutoId { get; set; }

    public int Quantidade { get; set; } = 0;

    public string? Descricao { get; set; }

    public double ValorUnitario { get; set; } = 0;

    public double Subtotal { get; set; } = 0;
}
