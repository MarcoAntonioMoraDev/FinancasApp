using FinancasApp.Data.Entities;
using FinancasApp.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Data.Contexts
{
    //classe para configuração do acesso
    //ao banco de dados realizado pelo EntityFramework
    //REGRA 1: Herdar DbContext :
    public class DataContext : DbContext
    {
        //REGRA 2: Implementar o método 'OnConfiguring'
        //para mapearmos a string de conexão do banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //configurando o caminho do banco de dados (connectionstring)
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDFinancasApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        //REGRA 3: Implementar o metodo 'OnModelCreating' para 
        //adicionar cada classe de mapeamento do projeto
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de mapeamento do projeto
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }

        //REGRA 4: Para cada entidade do projeto declare
        //uma propriedade do tipo DBSet
        public DbSet<Usuario> Usuario { get; set; }




    }
}
