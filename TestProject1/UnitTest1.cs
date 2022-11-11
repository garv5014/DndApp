using System.Diagnostics.Metrics;
using Xunit;
using Bunit;
using DndApp.Pages;
namespace TestProject1
{
    public class RandomTester
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
    }
}