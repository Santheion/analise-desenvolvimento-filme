using Locadora.Filmes.Dominio;
using Locadora.Filmes.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Filmes.Dados.Entity.TypeConfiguration
{
    class AlbumTypeConfiguration : LocadoraEntityAbstractConfig<Album>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Nome");

            Property(p => p.Ano)
                .IsRequired()
                .HasColumnName("Ano");

            Property(p => p.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(1000);
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Albuns");
        }
    }
}
