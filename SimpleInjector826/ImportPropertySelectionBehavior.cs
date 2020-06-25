using SimpleInjector.Advanced;
using System;
using System.Linq;
using System.Reflection;

namespace SimpleInjector826
{
    internal class ImportPropertySelectionBehavior : IPropertySelectionBehavior
    {
        public bool SelectProperty(Type implementationType, PropertyInfo prop) =>
            prop.GetCustomAttributes(typeof(ImportAttribute)).Any();
    }
}
