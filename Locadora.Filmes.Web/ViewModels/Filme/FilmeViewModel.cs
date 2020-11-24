using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeViewModel
    {
        [Required(ErrorMessage = "Id Obrigatório")]
        public long IdFilme { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório")]
        [Display(Name = "Nome do Filme")]
        public string NomeFilme { get; set; }

        [Required(ErrorMessage = "Selecione um álbum")]
        [Display(Name = "Nome do álbum")]
        public int IdAlbum { get; set; }
    }
}