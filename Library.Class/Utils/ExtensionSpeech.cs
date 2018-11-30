using System.Linq;
using System.Speech.Synthesis;

namespace Library.Class.Utils
{
    public static class ExtensionSpeech
    {
        public static void speech(string args) // defining the function which will accept a string parameter
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult); // to change VoiceGender and VoiceAge check out those links below
            synthesizer.Volume = 100;  // (0 - 100)
            synthesizer.Rate = 0;     // (-10 - 10)
            var z = "";
            foreach (var item in synthesizer.GetInstalledVoices().Select(voice => voice.VoiceInfo.Culture.ToString()).ToList().Where(item => item.Contains("pt-BR")))
            {
                z = item;
                return;
            }
            //synthesizer.SelectVoice(z);
            //synthesizer.Speak("Eu acho que ja consegui");   // Asynchronous
            synthesizer.SpeakAsync(args);
            //synthesizer.SpeakAsync("Então" + args); // here args = pran
        }
    }
}
 