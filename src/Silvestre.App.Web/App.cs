using System;
using System.Reflection;

namespace Silvestre.App.Web
{
    public static class App
    {
        public static string AppVersion => Assembly.GetExecutingAssembly().GetName().Version?.ToString(3);
    }
}
