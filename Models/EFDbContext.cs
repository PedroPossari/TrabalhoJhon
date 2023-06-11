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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=trabalholipa;uid=root;pwd=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.11-mariadb"));

}
