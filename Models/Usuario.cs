using System;
using System.Collections.Generic;

namespace TrabalhoLipa.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string NomeCompleto { get; set; } = null!;

    public string User { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public string Situacao { get; set; } = "Ativo";

    public string Administrador { get; set; } = "Não";

}

