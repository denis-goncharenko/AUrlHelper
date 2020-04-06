using System;
using Xunit;

namespace AUrlHelper.Tests
{
    public class AUrlHelperTests
    {
        [Theory]
        [InlineData("http://www.test.com/image.png", "image.png")]
        [InlineData("http://www.test.com/document.pdf", "document.pdf")]
        [InlineData("http://www.test.com/audio.mp3", "audio.mp3")]
        public void Should_Return_File_Name_With_Extension(string url, string excepted)
        {
            var fileName = AUrlHelper.GetFileName(url);

            Assert.Equal(fileName, excepted);
        }

        [Theory]
        [InlineData("http://www.test.com/image.png", "image")]
        [InlineData("http://www.test.com/document.pdf", "document")]
        [InlineData("http://www.test.com/audio.mp3", "audio")]
        public void Should_Return_File_Name_Without_Extension(string url, string excepted)
        {
            var fileName = AUrlHelper.GetFileNameWithoutExtension(url);

            Assert.Equal(fileName, excepted);
        }

        [Fact]
        public void Should_Throw_ArgumentException_If_Url_Without_File()
        {
            var urlWithoutFile = "http://www.test.com";

            Assert.Throws<ArgumentException>(() => AUrlHelper.GetFileName(urlWithoutFile));
            Assert.Throws<ArgumentException>(() => AUrlHelper.GetFileNameWithoutExtension(urlWithoutFile));
        }

        [Fact]
        public void Should_Throw_UriFormatException_If_Url_Invalid()
        {
            var urlWithoutFile = "test.com";

            Assert.Throws<UriFormatException>(() => AUrlHelper.GetFileName(urlWithoutFile));
            Assert.Throws<UriFormatException>(() => AUrlHelper.GetFileNameWithoutExtension(urlWithoutFile));
        }

        [Theory]
        [InlineData("http://www.test.com/assets/images/image.png", "images")]
        [InlineData("http://www.test.com/assets/documents/document.pdf", "documents")]
        public void Should_Return_Folder_Name(string url, string excepted)
        {
            var fileName = AUrlHelper.GetFolderName(url);

            Assert.Equal(fileName, excepted);
        }
    }
}
