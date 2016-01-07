using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd.Parser.Test
{
    public static class ParseEngineExtensions
    {

        /// <summary>
        /// Parses the given string from XML
        /// </summary>
        /// <param name="subject">The Parser which is applied</param>
        /// <param name="content">The content of the XML file</param>
        /// <returns>The <see cref="XmlElement"/> that subject.Parse(...) returned</returns>

        public static XmlElement ParseTestString(this ParserEngine subject, string content)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(content);
            writer.Flush();
            stream.Position = 0;

            var result = subject.Parse(stream);

            return result;
        }
    }
}
