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

        [Fact]
        public void TestMinimalXml_Parse_WithAttributes()
        {
            // Arrange
            var subject = new ParserEngine();

            // Act
            var result = subject.ParseTestString("<sample attr=\"attributecontent\"></sample>");

            // Assert
            result.Attributes.Should().ContainSingle(x => x.Name == "attr" && x.Content == "attributecontent");
        }


        [Fact]
        public void TestMinimalXml_Parse_WithChildren()
        {
            // Arrange
            var subject = new ParserEngine();

            // Act
            var result = subject.ParseTestString("<sample><childnode></childnode></sample>");

            // Assert
            result.Children.Should().ContainSingle(x => x.Name == "childnode");
        }



        [Fact]
        public void TestMinimalXml_Parse_WithCompactNotation()
        {
            // Arrange
            var subject = new ParserEngine();

            // Act
            var result = subject.ParseTestString("<sample />");

            // Assert
            result.Should().NotBeNull();
            result.Name.Should().Be("sample");
        }
    }
}
