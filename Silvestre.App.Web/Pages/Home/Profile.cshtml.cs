using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Silvestre.App.Web.Pages.Home
{
    public class ProfileModel : PageModel
    {
        public ProfileModel()
        {
            this.ProgrammingLanguagesBackend = new Dictionary<string, uint>
            {
                { "C#", 10 },
                { "Java", 7 },

                { "C", 7 },
                { "C++", 5 },

                { "Rust", 2 }
            };

            this.ProgrammingLanguagesFrontend = new Dictionary<string, uint>
            {
                { "HTML", 6 },
                { "CSS", 5 },
                { "JavaScript", 6 },
            };

            this.TechnologiesBackend = new Dictionary<string, uint>
            {
                { "MSSQL", 8 },
                { "Postgres", 6 },
                { "MongoDB", 5 },

                { ".NET", 9 },
                { "ASP.NET MVC", 8 },
                { "ASP.NET WebApi", 8 },
                { "gRPC", 7 },
                { "Dapr", 6 }
            };

            this.TechnologiesFrontend = new Dictionary<string, uint>
            {
                { "Bootstrap", 5 },
                { "TailwindCSS", 5 },
                { "KnockoutJS", 6 }
            };
        }

        public uint SkillsMax => 10;

        public IDictionary<string, uint> ProgrammingLanguagesBackend
        {
            get; init;
        }

        public IDictionary<string, uint> ProgrammingLanguagesFrontend
        {
            get; init;
        }

        public IDictionary<string, uint> TechnologiesBackend
        {
            get; init;
        }

        public IDictionary<string, uint> TechnologiesFrontend
        {
            get; init;
        }
    }
}
