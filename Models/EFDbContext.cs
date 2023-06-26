using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoLipa.Models;

public partial class EFDbContext : DbContext
{
    public EFDbContext()
    {
    }

    public EFDbContext(DbContextOptions<EFDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ItemVenda> ItensVendas { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venda> Vendas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
=> optionsBuilder.UseMySql("server=localhost;database=Trabalholoja;uid=root;password=P@ssari1", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.11.4-mariadb"));

}
