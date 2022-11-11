using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndApp.Pages;
using FluentAssertions;

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
        public void PrintNumberElement() {

            using var ctx = new TestContext();

            int count = 1;
            int dicesides = 1; 
            // Render Counter component.
            var component = ctx.RenderComponent<DiceRoller>(parameters => parameters
            .Add(p => p.DieSides, dicesides)
            .Add(p => p.DieCount, count));

            component.Find("button").Click();
            component.Find("td").MarkupMatches("<td class=\"card col-sm-3 m-2\" style=\"width: 16rem;\">1</td>");
        }

        [Fact]
        public void StoreNumberInRange()
        {

            using var ctx = new TestContext();

            int count = 1;
            int dicesides = 20;
            // Render Counter component.
            var component = ctx.RenderComponent<DiceRoller>(parameters => parameters
            .Add(p => p.DieSides, dicesides)
            .Add(p => p.DieCount, count));

            component.Find("button").Click();

            component.Instance.RollResults[0].Should().BeGreaterThanOrEqualTo(1);
            component.Instance.RollResults[0].Should().BeLessThanOrEqualTo(dicesides);
        }
        [Fact]
        public void StoreListofRandomInRange()
        {

            using var ctx = new TestContext();

            int count = 20;
            int dicesides = 20;
            // Render Counter component.
            var component = ctx.RenderComponent<DiceRoller>(parameters => parameters
            .Add(p => p.DieSides, dicesides)
            .Add(p => p.DieCount, count));

            component.Find("button").Click();
            foreach (int i in component.Instance.RollResults)
            {
                i.Should().BeGreaterThanOrEqualTo(1);
                i.Should().BeLessThanOrEqualTo(dicesides);
            }
        }
    }
}
