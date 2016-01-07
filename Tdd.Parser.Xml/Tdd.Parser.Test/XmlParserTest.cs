using FluentAssertions;
using Xunit;

namespace Tdd.Parser.Test
{
    public class XmlParserTest
    {
        [Fact]
        public void TestMinimalXml_Parse()
        {
            // Arrange
            var subject = new ParserEngine();

            // Act
            var result = subject.ParseTestString("<sample></sample>");

            // Assert
            result.Should().NotBeNull();
            result.Name.Should().Be("sample");
        }
    }
}
