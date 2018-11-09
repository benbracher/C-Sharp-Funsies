using System;
using _08_Repository_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Repository_Pattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void StreamingContent_SetTitle_ShouldBeCorrectString()
        {
            //--Arrange
            StreamingContent content = new StreamingContent();
            content.Title = "Bolt";

            //--Act
            var actual = content.Title;
            var expected = "Bolt";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_SetMatureBoolean_ShouldReturnTrue()
        {
            //--Arrange
            StreamingContent content = new StreamingContent();
            content.IsMature = true;

            //--Act
            var actual = content.IsMature;
            var expected = true;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_SetRating_ShouldBeCorrectInteger()
        {
            //-Arrange
            StreamingContent content = new StreamingContent();
            content.Rating = 5;

            //--Act
            var actual = content.Rating;
            var expected = 5;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_SetGenre_ShouldBeCorrectString()
        {
            //--Arrange
            StreamingContent content = new StreamingContent();
            content.Genre = "Space Opera";

            //--Act
            var actual = content.Genre;
            var expected = "Space Opera";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_Constructor_ShouldHoldCorrectValues()
        {
            //--Arrange
            StreamingContent content = new StreamingContent("Star Wars", "Space Opera", 5, false);

            //--Act
            var actual = content.Title;
            var expected = "Star Wars";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContentRepository_AddContentToList_ShouldReturnCorrectCount()
        {
            //--Arrange
            StreamingContentRepository contentRepo = new StreamingContentRepository();
            var list = contentRepo.GetContentList();
            StreamingContent content = new StreamingContent();


            //--Act
            contentRepo.AddContentToList(content);
            var actual = list.Count;
            var expected = 1;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
