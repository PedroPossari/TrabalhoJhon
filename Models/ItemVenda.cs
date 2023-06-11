using System;
using System.Collections.Generic;

namespace TrabalhoLipa.Models;

public partial class ItemVenda
{
    public int Id { get; set; }

    public Produto Produto { get; set; } = null!;

    public int Quantidade { get; set; } = 0;

    public string? Descricao { get; set; }

    public double ValorUnitario { get; set; } = 0;

    public double Subtotal { get; set; } = 0;
}
