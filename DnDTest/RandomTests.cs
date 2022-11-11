using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndApp.Pages;
namespace DnDTest
{
    public class RandomTests
    {
        [Fact]
        public void Renders()
        {
            using var ctx = new TestContext();

            // Render Counter component.
            var component = ctx.RenderComponent<DiceRoller>();

            // Assert: first, find the parent_name vital element, then verify its content.
            Assert.Equal("Roll", component.Find($".btn").TextContent);


        }
        [Fact]
        public void RandomNumber() {
            using var ctx = new TestContext();

            // Render Counter component.
            var component = ctx.RenderComponent<DiceRoller>();
        }
    }
}
