using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NetCoreWebApp.Controllers;
using NetCoreWebApp.Models;
using NetCoreWebApp.Models.Repositories;
using System.Collections.Generic;

namespace NetCoreWebAppTests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void DataAction_CharacterObjectReturned()
        {
            //Arrange
            Mock<ICharacterRepository> characterRepository = new Mock<ICharacterRepository>();
            characterRepository.Setup(x => x.GetCharacters()).Returns(new List<Character>() { new Character() });
            var homeController = new HomeController(characterRepository.Object);

            //Act
            var viewResult = homeController.Data();

            //Assert
            var character = viewResult.ViewData["character"];
            Assert.IsInstanceOfType(character, typeof(Character));
        }
    }
}
