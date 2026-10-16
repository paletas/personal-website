using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace Silvestre.App.Web.Models
{
    // Serves every routable page a second time under /pt.
    public class CulturePrefixConvention : IPageRouteModelConvention
    {
        public void Apply(PageRouteModel model)
        {
            foreach (var selector in model.Selectors.ToList())
            {
                var existing = selector.AttributeRouteModel;
                if (existing?.Template is null) continue;
                if (existing.Template.Equals("pt", StringComparison.OrdinalIgnoreCase)
                    || existing.Template.StartsWith("pt/", StringComparison.OrdinalIgnoreCase)) continue;

                model.Selectors.Add(new SelectorModel
                {
                    AttributeRouteModel = new AttributeRouteModel
                    {
                        Template = AttributeRouteModel.CombineTemplates("pt", existing.Template)
                    }
                });
            }
        }
    }
}
