using LinktreeApp.Models;
using System.Collections.Generic;

namespace LinktreeApp.Services
{
    public class LinkService
    {
        public List<Link> GetLinks()
        {
            return new List<Link>
            {
                new Link { Id = 1, Title = "GitHub", Url = "https://github.com/sampaio-arthur" },
                new Link { Id = 2, Title = "LinkedIn", Url = "https://www.linkedin.com/in/sampaio-arthur/" },
                new Link { Id = 3, Title = "Gmail", Url = "mailto:arthurbarrasampaio@gmail.com" },
                new Link { Id = 4, Title = "Whatsapp", Url = "https://wa.me/5548999895574" },
                new Link { Id = 5, Title = "Instagram", Url = "https://www.instagram.com/sampaio__arthur/" },
                new Link { Id = 6, Title = "Lattes", Url = "http://lattes.cnpq.br/4591176014728041" }
                
                // Adicione mais links conforme necessário
            };
        }
    }
}
