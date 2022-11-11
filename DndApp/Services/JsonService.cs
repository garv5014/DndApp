using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using DndApp.Data;

namespace DndApp.Services
{

    public class JsonService
    {
        public HttpClient httpClient;

        public JsonService(HttpClient context)
        {
            httpClient = context;
        }

        public async Task<ApiClasses.Rootobject> ListItem(string url)
        {
            ApiClasses.Rootobject myJson;
            myJson = await JsonSerializer.DeserializeAsync<ApiClasses.Rootobject>
            (await httpClient.GetStreamAsync($"https://www.dnd5eapi.co/api/{url}"));
            return myJson;
        }

        public async Task<Spell.Rootobject> Spell(string url)
        {
            Spell.Rootobject myJson;
            myJson = await JsonSerializer.DeserializeAsync<Spell.Rootobject>
            (await httpClient.GetStreamAsync($"https://www.dnd5eapi.co/api/spells/{url}"));
            return myJson;
        }
        public async Task<CharacterClass.Rootobject> CharClass(string url)
        {
            CharacterClass.Rootobject myJson;
            myJson = await JsonSerializer.DeserializeAsync<CharacterClass.Rootobject>
            (await httpClient.GetStreamAsync($"https://www.dnd5eapi.co/api/classes/{url}"));
            return myJson;
        }

        public async Task<Races.Rootobject> Race(string url)
        {
            Races.Rootobject myJson;
            myJson = await JsonSerializer.DeserializeAsync<Races.Rootobject>
            (await httpClient.GetStreamAsync($"https://www.dnd5eapi.co/api/races/{url}"));
            return myJson;
        }
    }
}
