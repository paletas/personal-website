using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Silvestre.App.Blog.Web.Core.Parsers
{
    public static class YAML
    {
        private static IDeserializer _Deserializer;

        static YAML()
        {
            _Deserializer = new DeserializerBuilder().WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
        }

        public static T Deserialize<T>(string yamlContent)
        {
            return _Deserializer.Deserialize<T>(yamlContent);
        }

        public static T Deserialize<T>(Stream yamlStream)
        {
            using TextReader reader = new StreamReader(yamlStream);
            return _Deserializer.Deserialize<T>(reader);
        }
    }
}
