using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Contato
    {
        [Required(ErrorMessageResourceType = typeof(LojaVirtual.Libraries.Lang.Mensagem_pt_BR), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(LojaVirtual.Libraries.Lang.Mensagem_pt_BR), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }
        [Required(ErrorMessageResourceType = typeof(LojaVirtual.Libraries.Lang.Mensagem_pt_BR), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(LojaVirtual.Libraries.Lang.Mensagem_pt_BR), ErrorMessageResourceName = "MSG_E004")]
        public string Email { get; set; }
        [Required(ErrorMessageResourceType = typeof(LojaVirtual.Libraries.Lang.Mensagem_pt_BR), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(10, ErrorMessageResourceType = typeof(LojaVirtual.Libraries.Lang.Mensagem_pt_BR), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(1000, ErrorMessageResourceType = typeof(LojaVirtual.Libraries.Lang.Mensagem_pt_BR), ErrorMessageResourceName = "MSG_E003")]
        public string Texto { get; set; }

    }
}
