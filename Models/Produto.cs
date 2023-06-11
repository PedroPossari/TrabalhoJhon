using System;
using System.Collections.Generic;

namespace TrabalhoLipa.Models;

public partial class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string? CodigoBarras { get; set; }

    public string? Marca { get; set; }

    public double? Peso { get; set; }

    public double? Largura { get; set; }

    public double? Altura { get; set; }

    public double? Profundidade { get; set; }

    public string Situacao { get; set; } = "Ativo";

    public string Condicao { get; set; } = "Novo";

    public double PrecoVenda { get; set; } = 0;

    public int QuantidadeEstoque { get; set; } = 0;

    public DateTime DataCadastro { get; set; } = DateTime.Now;

}
