using System;
using System.Reflection;

namespace Silvestre.App.Web
{
    public static class App
    {
        public static Version AppVersion => Assembly.GetExecutingAssembly().GetName().Version;
    }
}
