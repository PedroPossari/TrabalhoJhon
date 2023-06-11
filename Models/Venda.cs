using System;
using System.Collections.Generic;

namespace TrabalhoLipa.Models;

public partial class Venda
{
    public int Id { get; set; }

    public DateTime DataVenda { get; set; }

    public int TotalItens { get; set; } = 0;

    public double Subtotal { get; set; } = 0;

    public double Desconto { get; set; } = 0;

    public double ValorTotal { get; set; } = 0;

    public string FormaPagamento { get; set; } = null!;

    public string Situacao { get; set; } = "Aberta";

    public string? Observacoes { get; set; }

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public Cliente Cliente { get; set; } = null!;

    public Usuario Usuario { get; set; } = null!;

    public virtual ICollection<ItemVenda> Itemvenda { get; set; } = new List<ItemVenda>();
}
