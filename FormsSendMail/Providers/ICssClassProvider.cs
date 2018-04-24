using System.Collections.Generic;
using DynamicPlaceholderGrids.Models;
using Sitecore.Mvc.Presentation;

namespace DynamicPlaceholderGrids.Providers
{
    public interface ICssClassProvider
    {
        List<CssClass> GetCssClasses(string rawValue);
        string GetInlineCssClasses(DynamicPlaceholderRenderContext context, string param);
        CssClass GetCssClass(string pathOrId);
    }
}