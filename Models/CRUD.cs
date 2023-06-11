using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLipa.Models
{
    public static class CRUD
    {
        private static readonly EFDbContext bd = new EFDbContext();

        #region Cliente

        #region Inserir

        ///<summary>Insere um Cliente no banco de dados</summary>
        public static void InserirCliente(Cliente cliente)
        {
            bd.Clientes.Add(cliente);
            bd.SaveChanges();
        }

        #endregion

        #region Alterar

        ///<summary>Altera um Cliente no banco de dados</summary>
        public static void AlterarCliente(Cliente cliente)
        {
            bd.Clientes.Update(cliente);
            bd.SaveChanges();
        }

        #endregion

        #region Listar

        ///<summary>Lista todos os Clientes cadastrados</summary>
        ///<returns>Retorna uma lista de Clientes</returns>
        public static List<Cliente> ListarClientes()
        {
            return bd.Clientes.ToList();
        }
        ///<summary>Listar Clientes por Nome</summary>
        ///<returns>retorna uma lista de Clientes</returns>
        public static List<Cliente> ListarClientesPorNome(string nome)
        {
            return bd.Clientes.Where(c => c.NomeCompleto.Contains(nome)).ToList();
        }
        ///<summary>Listar Clientes por Situação</summary>
        ///<returns>Rertorna uma lista de Clientes</returns>
        public static List<Cliente> ListarClientesPorSituacao(string situacao)
        {
            return bd.Clientes.Where(c => c.Situacao.Contains(situacao)).ToList();
        }

        #endregion

        #region Buscar

        ///<summary>Busca um Cliente pelo Id</summary>
        ///<returns>Retorna um único Cliente ou null</returns>
        public static Cliente? BuscarClientePorId(int id)
        {
            return bd.Clientes.Find(id);
        }
        ///<summary>Busca um Cliente pelo CPF</summary>
        ///<returns>Rertorna um único Cliente ou null</returns>
        public static Cliente? BuscarClientePorCpf(string cpf)
        {
            return bd.Clientes.FirstOrDefault(c => c.Cpf == cpf);
        }
        ///<summary>Buca um Cliente pelo RG</summary>
        ///<returns>Rertorna um único Cliente ou null</returns>
        public static Cliente? BuscarClientePorRg(string rg)
        {
            return bd.Clientes.FirstOrDefault(c => c.Rg == rg);
        }

        #endregion

        #region Excluir

        ///<summary>Exclui um Cliente do banco de dados</summary>
        public static void ExcluirCliente(Cliente cliente)
        {
            bd.Clientes.Remove(cliente);
            bd.SaveChanges();
        }

        #endregion

        #endregion

        #region Usuário

        #region Inserir

        ///<summary>Insere um Usuário no banco de dados</summary>
        public static void InserirUsuario(Usuario usuario)
        {
            bd.Usuarios.Add(usuario);
            bd.SaveChanges();
        }

        #endregion

        #region Alterar

        ///<summary>Altera um Usuário no banco de dados</summary>
        public static void AlterarUsuario(Usuario usuario)
        {
            bd.Usuarios.Update(usuario);
            bd.SaveChanges();
        }

        #endregion

        #region Listar

        ///<summary>Lista todos os Usuários cadastrados</summary>
        ///<returns>Rertorna uma lista de Usuários</returns>
        public static List<Usuario> ListarUsuarios()
        {
            return bd.Usuarios.ToList();
        }
        ///<summary>Lista Usuários por Nome</summary>
        ///<returns>Rertorna uma lista de Usuários</returns>
        public static List<Usuario> ListarUsuariosPorNome(string nome)
        {
            return bd.Usuarios.Where(u => u.NomeCompleto.Contains(nome)).ToList();
        }
        ///<summary>Lista Usuários por Situação</summary>
        ///<returns>Rertorna uma lista de Usuários</returns>
        public static List<Usuario> ListarUsuariosPorSituacao(string situacao)
        {
            return bd.Usuarios.Where(u => u.Situacao.Contains(situacao)).ToList();
        }

        #endregion

        #region Buscar

        ///<summary>Busca um Usuário pelo Id</summary>
        ///<returns>Rertorna um único Usuário ou null</returns>
        public static Usuario? BuscarUsuarioPorId(int id)
        {
            return bd.Usuarios.Find(id);
        }
        ///<summary>Busca um Usuário pelo User</summary>
        ///<returns>Rertorna um único Usuário ou null</returns>
        public static Usuario? BuscarUsuarioPorUser(string user)
        {
            return bd.Usuarios.FirstOrDefault(u => u.User == user);
        }

        #endregion

        #region Excluir

        ///<summary>Exclui um Usuário do banco de dados</summary>
        public static void ExcluirUsuario(Usuario usuario)
        {
            bd.Usuarios.Remove(usuario);
            bd.SaveChanges();
        }

        #endregion

        #endregion

        #region Venda

        #region Inserir

        ///<summary>Insere uma Venda no banco de dados</summary>
        public static void InserirVenda(Venda venda)
        {
            bd.Vendas.Add(venda);
            bd.SaveChanges();
        }

        #endregion

        #region Alterar

        ///<summary>Altera uma Venda no banco de dados</summary>
        public static void AlterarVenda(Venda venda)
        {
            bd.Vendas.Update(venda);
            bd.SaveChanges();
        }

        #endregion

        #region Listar

        ///<summary>Lista todas as Vendas cadastradas</summary>
        ///<returns>Rertorna uma lista de Vendas</returns>
        public static List<Venda> ListarVendas()
        {
            return bd.Vendas.ToList();
        }
        ///<summary>Lista todas as Vendas feitas em uma data</summary>
        ///<returns>Rertorna uma lista de Vendas</returns>
        public static List<Venda> ListarVendasPorData(DateTime data)
        {
            return bd.Vendas.Where(v => v.DataVenda == data).ToList();
        }
        ///<summary>Lista todas as vendas feitas em um Período</summary>
        ///<returns>Rertorna uma lista de Vendas</returns>
        public static List<Venda> ListarVendasPorPeriodo(DateTime inicio, DateTime fim)
        {
            return bd.Vendas.Where(v => v.DataVenda >= inicio && v.DataVenda <= fim).ToList();
        }
        ///<summary>Lista todas as Vendas por Situação</summary>
        ///<returns>Rertorna uma lista de Vendas</returns>
        public static List<Venda> ListarVendasPorSituacao(string situacao)
        {
            return bd.Vendas.Where(v => v.Situacao.Contains(situacao)).ToList();
        }
        ///<summary>Lista as Vendas por Cliente</summary>
        ///<returns>Rertorna uma lista de Vendas</returns>
        public static List<Venda> ListarVendasPorCliente(Cliente cliente)
        {
            return bd.Vendas.Where(v => v.Cliente == cliente).ToList();
        }
        ///<summary>Lista as Vendas por Usuário</summary>
        ///<returns>Rertorna uma lista de Vendas</returns>
        public static List<Venda> ListarVendasPorUsuario(Usuario usuario)
        {
            return bd.Vendas.Where(v => v.Usuario == usuario).ToList();
        }
        ///<summary>Lista as Vendas por faixa de Valor</summary>
        ///<returns>Rertorna uma lista de Vendas</returns>
        public static List<Venda> ListarVendasPorFaixaDeValor(double inicio, double fim)
        {
            return bd.Vendas.Where(v => v.ValorTotal >= inicio && v.ValorTotal <= fim).ToList();
        }

        #endregion

        #region Buscar

        ///<summary>Busca uma Venda pelo Id</summary>
        ///<returns>Rertorna uma única Venda ou null</returns>
        public static Venda? BuscarVendaPorId(int id)
        {
            return bd.Vendas.Find(id);
        }

        #endregion

        #region Excluir

        ///<summary>Exclui uma Venda do banco de dados</summary>
        public static void ExcluirVenda(Venda venda)
        {
            bd.Vendas.Remove(venda);
            bd.SaveChanges();
        }

        #endregion

        #endregion

        #region Produto

        #region Inserir

        ///<summary>Insere um Produto no banco de dados</summary>
        public static void InserirProduto(Produto produto)
        {
            bd.Produtos.Add(produto);
            bd.SaveChanges();
        }

        #endregion

        #region Alterar

        ///<summary>Altera um Produto no banco de dados</summary>
        public static void AlterarProduto(Produto produto)
        {
            bd.Produtos.Update(produto);
            bd.SaveChanges();
        }

        #endregion

        #region Listar

        ///<summary>Lista todos os Produtos cadastrados</summary>
        ///<returns>Rertorna uma lista de Produtos</returns>
        public static List<Produto> ListarProdutos()
        {
            return bd.Produtos.ToList();
        }
        ///<summary>Lista todos os Produtos por Nome</summary>
        ///<returns>Rertorna uma lista de Produtos</returns>
        public static List<Produto> ListarProdutosPorNome(string nome)
        {
            return bd.Produtos.Where(p => p.Nome.Contains(nome)).ToList();
        }
        ///<summary>Lista todos os Produtos em uma faixa de Preço</summary>
        ///<returns>Rertorna uma lista de Produtos</returns>
        public static List<Produto> ListarProdutosPorFaixaDePreco(double inicio, double fim)
        {
            return bd.Produtos.Where(p => p.PrecoVenda >= inicio && p.PrecoVenda <= fim).ToList();
        }
        ///<summary>Lista os Produtos por Situação</summary>
        ///<returns>Rertorna uma lista de Produtos</returns>
        public static List<Produto> ListarProdutosPorSituacao(string situacao)
        {
            return bd.Produtos.Where(p => p.Situacao.Contains(situacao)).ToList();
        }
        ///<summary>Lista os Produtos por Condicao</summary>
        ///<returns>Rertorna uma lista de Produtos</returns>
        public static List<Produto> ListarProdutosPorCondicao(string condicao)
        {
            return bd.Produtos.Where(p => p.Condicao.Contains(condicao)).ToList();
        }

        #endregion

        #region Buscar

        ///<summary>Busca um Produto pelo Id</summary>
        ///<returns>Rertorna um único Produto ou null</returns>
        public static Produto? BuscarProdutoPorId(int id)
        {
            return bd.Produtos.Find(id);
        }

        #endregion

        #region Excluir

        ///<summary>Exclui um Produto do banco de dados</summary>
        public static void ExcluirProduto(Produto produto)
        {
            bd.Produtos.Remove(produto);
            bd.SaveChanges();
        }

        #endregion

        #endregion

    }
}