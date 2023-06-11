using System;
using System.Collections.Generic;

namespace TrabalhoLipa.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string NomeCompleto { get; set; } = null!;

    public string Situacao { get; set; } = "Aberta";

    public string? Cpf { get; set; }

    public string? Rg { get; set; }

    public string? Genero { get; set; } 

    public DateTime? DataNascimento { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Profissao { get; set; }

    public string? Nacionalidade { get; set; }

    public string? Telefone { get; set; }

    public string? Celular { get; set; }

    public bool? Whatsapp { get; set; }

    public string? Email { get; set; }

    public string? Endereco { get; set; }

    public int? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Uf { get; set; }

    public string? Cep { get; set; }

    public string? Observacoes { get; set; }

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public virtual ICollection<Venda> Vendas { get; set; } = new List<Venda>();
}

