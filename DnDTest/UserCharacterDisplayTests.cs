using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndApp.Pages;
using FluentAssertions;
using DndApp.Components;
using DndApp.Data;
using DndApp.Services;
using static DndApp.Services.JsonService;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http;

namespace DnDTest
{
    public class UserCharacterDisplayTests
    {

        [Fact]
        public void Render()
        {
            
            using var ctx = new TestContext();
            ctx.Services.AddSingleton<HttpClient>(new HttpClient());
            ctx.Services.AddSingleton<JsonService>(new JsonService());
            UserCharacterInfo userCharacterInfo = new UserCharacterInfo();
            userCharacterInfo.Name = "Test";
            userCharacterInfo.Description = "Description";
            userCharacterInfo.Id = 5;
            userCharacterInfo.Class = "Bard";
            userCharacterInfo.Race = "Elf";
            userCharacterInfo.Age = 300;
            userCharacterInfo.Charisma = 5;
            userCharacterInfo.Intelligence = 5;
            userCharacterInfo.Strength = 8;
            userCharacterInfo.Dexterity = 5;
            userCharacterInfo.Constitution = 5;
            userCharacterInfo.Wisdom = 5;
            userCharacterInfo.UserId = "olherwfg3r4e982389d2hig3!";

            // Render Counter component.
            var component = ctx.RenderComponent<UserCharacter>(parameters => parameters
            .Add(p => p.characterInfo, userCharacterInfo));

            component.Find("h3").MarkupMatches("<h3> Initiative </h3>");


            // Assert: first, find the parent_name vital element, then verify its content.
            //Assert.Equal("Roll", component.Find($".btn").TextContent);
        }
        [Fact]
        public void TestElementPresentation()
        {
            using var ctx = new TestContext();
            ctx.Services.AddSingleton<HttpClient>(new HttpClient());
            ctx.Services.AddSingleton<JsonService>(new JsonService());
            UserCharacterInfo userCharacterInfo = new UserCharacterInfo();
            userCharacterInfo.Name = "Test";
            userCharacterInfo.Description = "Description";
            userCharacterInfo.Id = 5;
            userCharacterInfo.Class = "Bard";
            userCharacterInfo.Race = "Elf";
            userCharacterInfo.Age = 300;
            userCharacterInfo.Charisma = 5;
            userCharacterInfo.Intelligence = 5;
            userCharacterInfo.Strength = 8;
            userCharacterInfo.Dexterity = 5;
            userCharacterInfo.Constitution = 5;
            userCharacterInfo.Wisdom = 5;
            userCharacterInfo.UserId = "olherwfg3r4e982389d2hig3!";

            var component = ctx.RenderComponent<UserCharacter>(parameters => parameters
           .Add(p => p.characterInfo, userCharacterInfo));

            component.Find("p").MarkupMatches("<p class=\"h3\">-2</p>");
        }
       
        [Fact]
        public void TestInitiative()
        {
            using var ctx = new TestContext();
            ctx.Services.AddSingleton<HttpClient>(new HttpClient());
            ctx.Services.AddSingleton<JsonService>(new JsonService());
            UserCharacterInfo userCharacterInfo = new UserCharacterInfo();
            userCharacterInfo.Name = "Test";
            userCharacterInfo.Description = "Description";
            userCharacterInfo.Id = 5;
            userCharacterInfo.Class = "Bard";
            userCharacterInfo.Race = "Elf";
            userCharacterInfo.Age = 300;
            userCharacterInfo.Charisma = 5;
            userCharacterInfo.Intelligence = 5;
            userCharacterInfo.Strength = 8;
            userCharacterInfo.Dexterity = 5;
            userCharacterInfo.Constitution = 5;
            userCharacterInfo.Wisdom = 5;
            userCharacterInfo.UserId = "olherwfg3r4e982389d2hig3!";

            var component = ctx.RenderComponent<UserCharacter>(parameters => parameters
           .Add(p => p.characterInfo, userCharacterInfo));

            component.Instance.cStats.initiative_Mod.Should().Be(-2);
        }

    }
}
