using System.Collections.Generic;
using System.Linq;
using DynamicPlaceholderGrids.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Text;

namespace DynamicPlaceholderGrids.Providers
{
    public class CssClassRepository : ICssClassProvider
    {
        private readonly IParameterTemplatesProvider _parameterTemplatesProvider = new ParameterTemplatesProvider();

        public List<CssClass> GetCssClasses(string rawValue)
        {
            var listString = new ListString(rawValue).Where(p=>!string.IsNullOrEmpty(p));
            var cssClasses = listString.Select(GetCssClass).Where(p => p != null).ToList();
            return cssClasses;
        }

        public CssClass GetCssClass(string pathOrId)
        {
            var item = Sitecore.Context.Item.Database.GetItem(pathOrId);
            return item == null ? null : new CssClass(item);
        }

        public string GetInlineCssClasses(DynamicPlaceholderRenderContext context, string param)
        {
            var rawCssClassesIds = _parameterTemplatesProvider.GetParameter(context, param);
            var cssClassesItems = GetCssClasses(rawCssClassesIds);
            return string.Join(" ", cssClassesItems.Select(p => p.CssClasses));
        }
    }
}