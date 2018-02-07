
using NUnit.Framework;
using Sandwich.App;

namespace Sandwich.Tests
{
    [TestFixture]
    public class Adding_Toppings
    {
        [Test]
        public void Click_Add_Tomato_Adds_Tomatoes_To_My_Order()
        {
            //Arrange
            var screen = new SandwichSelectionScreen();
            //Act
            screen.AddTomatoes(2);
            var sandwich = screen.BuildSandwich();
            //Assert
            Assert.AreEqual(2, sandwich.Tomatoes);
        }

        [Test]
        public void Click_Add_Tomato_Twice_Adds_TMore_omatoes_To_My_Order()
        {
            //Arrange
            var screen = new SandwichSelectionScreen();
            //Act
            screen.AddTomatoes(2);
            screen.AddTomatoes(2);
            var sandwich = screen.BuildSandwich();
            //Assert
            Assert.AreEqual(2, sandwich.Tomatoes);
        }
        
        [Test]
        public void Click_Add_Onions__Adds__Onions_To_My_Order()
        {
            //Arrange
            var screen = new SandwichSelectionScreen();

            //Act
            screen.AddOnions();
            var sandwich = screen.BuildSandwich();

            //Assert
            Assert.IsTrue( sandwich.Onions);
        }
    }
}
