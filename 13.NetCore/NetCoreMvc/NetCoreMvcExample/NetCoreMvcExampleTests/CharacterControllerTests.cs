using Moq;
using NetCoreMvcExample.Controllers;
using NetCoreMvcExample.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace NetCoreMvcExampleTests
{
    public class CharacterControllerTests
    {
        [Fact]
        public async void GetSingle_Call_GetSingleCharacterCalled()
        {
            //Arrange
            Mock<ICharactersRepository> mockCharactersRepository = new Mock<ICharactersRepository>();

            Character human = new Character("Finn", "Mertens", true, 14, 1, "Fairytail of the lost needle");
            mockCharactersRepository.Setup(x => x.GetSingleCharacter()).ReturnsAsync(human);

            CharacterController characterController = new CharacterController(mockCharactersRepository.Object);

            //Act
            await characterController.GetSingle();

            //Assert
            mockCharactersRepository.Verify(x => x.GetSingleCharacter(), Times.Once);
        }
    }
}
