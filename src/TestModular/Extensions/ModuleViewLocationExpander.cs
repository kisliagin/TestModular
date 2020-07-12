using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestModular.Extensions
{
    public class ModuleViewLocationExpander : IViewLocationExpander
    {
        private const string _moduleKey = "module";

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var module = context.AreaName;
            if (!string.IsNullOrWhiteSpace(module))
            {
                var moduleViewLocations = new string[]
                {
                        "/Modules/" + module + "/Views/{1}/{0}.cshtml",
                        "/Modules/" + module + "/Views/Shared/{0}.cshtml",
                        "/Views/{1}/{0}.cshtml",
                        "/Views/Shared/{0}.cshtml"
                };

                viewLocations = moduleViewLocations.Concat(viewLocations);
            }
            
            return viewLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            
        }
    }
}
