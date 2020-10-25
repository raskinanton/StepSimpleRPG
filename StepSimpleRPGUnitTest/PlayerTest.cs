using Microsoft.VisualStudio.TestTools.UnitTesting;
using StepSimpleRPG.Items;
using StepSimpleRPG.Players;
using System.Collections.Generic;

namespace StepSimpleRPGUnitTest
{
    [TestClass]
    public class PlayerTest : Player
    {
        public PlayerTest() : base(" ")
        {

        }

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var player = new PlayerTest();
            var expectedCounterValue = 3;

            // Act
            
            player.pushItems(new List<IItem>
            {
                new Potion(10),
                new Armor(10),
                new Treasure(10)
            });
            var actualCounterValue = player._items.Count;

            // Assert
            Assert.AreEqual(expectedCounterValue, actualCounterValue);
        }
    }
}
