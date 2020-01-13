using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class NewsletterEmail : Entity
    {
        [Required(ErrorMessageResourceType = typeof(LojaVirtual.Libraries.Lang.Mensagem_pt_BR), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(LojaVirtual.Libraries.Lang.Mensagem_pt_BR), ErrorMessageResourceName = "MSG_E004")]
        public string Email { get; set; }
    }
}
