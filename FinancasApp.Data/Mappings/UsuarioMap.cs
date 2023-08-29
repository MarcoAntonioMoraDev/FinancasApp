using FinancasApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Data.Mappings
{
    //Classe de mapeamento ORM para entidade Usuario
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //nome da tabela
            builder.ToTable("USUARIO");

            //chave primaria
            builder.HasKey(u => u.Id);

            //mapeamento dos campos
            builder.Property(u=>u.Id)
                .HasColumnName("ID")
                .IsRequired();
            
            builder.Property(u => u.Nome)
               .HasColumnName("NOME")
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(50)
                .IsRequired();
            //não aceita usuario com mesmo email
            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u => u.Senha)
               .HasColumnName("SENHA")
               .HasMaxLength(40)
               .IsRequired();

            builder.Property(u => u.DataHoraCriacao)
               .HasColumnName("DATAHORACRIACAO")
               .HasColumnType("datetime")
               .IsRequired();

        }
    }
}
