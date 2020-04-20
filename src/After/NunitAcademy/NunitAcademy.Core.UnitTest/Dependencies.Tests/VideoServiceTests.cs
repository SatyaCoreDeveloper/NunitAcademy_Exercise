using NUnit.Framework;
using NunitAcademy.Core.Dependencies;
using Moq;

namespace NunitAcademy.Core.UnitTest.Dependencies.Tests
{
    [TestFixture]
    class VideoServiceTests
    {
        private VideoService _videoService;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _videoService = new VideoService();
            _mockFileReader = new Mock<IFileReader>();
        }

        [Test]
        public void ReadVideoTitle_ValidVideoFile_ExpectedVideoTitle()
        {            
            _mockFileReader.Setup(fr => fr.Read("video.txt"))
                .Returns(new Video() { Id = 1001, Title = "Avengers", IsProcessed = false });
            
            var result = _videoService.ReadVideoTitle(_mockFileReader.Object, @"video.txt");
            Assert.That(result,Is.EqualTo("Avengers"));
        }

        [Test]
        public void ReadVideoTitle_EmptyTitle_ExpectedEmptyTitle()
        {
            
            _mockFileReader.Setup(fr => fr.Read("video.txt"))
                .Returns(new Video() { Id = 1001, Title = "", IsProcessed = false });

            var result = _videoService.ReadVideoTitle(_mockFileReader.Object, @"video.txt");
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void ReadVideoTitle_NoVideo_ExpectedErrorMessage()
        {
            
            Video video = null;
            _mockFileReader.Setup(fr => fr.Read("video.txt")).Returns(video);

            var result = _videoService.ReadVideoTitle(_mockFileReader.Object, @"video.txt");
            Assert.That(result, Does.StartWith("Error").IgnoreCase);
        }
        
    }
}
