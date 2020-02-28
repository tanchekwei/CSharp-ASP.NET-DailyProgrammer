using System.Collections.Generic;
using System.Web.Mvc;

namespace Smooshed_Morse_Code_1.Controllers
{
    public class MorseCode1Controller : Controller
    {
        const string AllMorseCode = ".- -... -.-. -.. . ..-. --. .... .. .--- -.- .-.. -- -. --- .--. --.- .-. ... - ..- ...- .-- -..- -.-- --..";
        // GET: MorseCode1
        [Route("MorseCode1")]
        public ActionResult Index()
        {
            char key = 'a';
            string[] list = AllMorseCode.Split(' ');
            List<KeyValuePair<char, string>> pair = new List<KeyValuePair<char, string>>();
            foreach (var morseCode in list)
            {
                pair.Add(new KeyValuePair<char, string>(key, morseCode));
                key++;
            }
            return View(pair);
        }
    }
}