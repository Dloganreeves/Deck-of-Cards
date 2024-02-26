using Microsoft.AspNetCore.DataProtection;
using System.Net;
using Newtonsoft.Json;

namespace Deck_of_Cards_lab.Models
{
    public class DeckDAL
    {
        public static DeckModel GetDeck()
        {
            //adjust 
            //setup
            string key = Secret.Key;
            string url = $"https://deckofcardsapi.com/api/deck/{key}/shuffle/";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert to Json 
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust
            //convert to c#
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(JSON);
            return result;
        }

        public static DrawModel Draw() 
        {
            // adjust
            //setup
            string key = Secret.Key;
            string url = $"https://deckofcardsapi.com/api/deck/{key}/draw/?count=5";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert to Json 
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust
            //convert to c#
            DrawModel result = JsonConvert.DeserializeObject<DrawModel>(JSON);
            return result;
        }
    }
}
