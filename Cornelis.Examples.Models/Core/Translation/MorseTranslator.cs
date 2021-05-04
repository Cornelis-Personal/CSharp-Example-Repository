using Cornelis.Examples.Models.Libraries;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cornelis.Examples.Models.Core.Translation
{
    public class MorseTranslator : ITranslator
    {
        public string TranslateFrom(string input)
        {
            string output = string.Empty;
            var words = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                // Check if the value exists
                var pair = MorseCodeLib.MorseCode.Where(x => string.Equals(x.Value, word))
                                                 .Select(e => (KeyValuePair<char, string>?)e)
                                                 .FirstOrDefault();

                if (pair != null)
                {
                    // It does so add the key
                    output += pair.Value.Key;
                }
            }
            return output.TrimStart();
        }

        public string TranslateTo(string input)
        {
            string output = string.Empty;
            string cleanedInput = string.Empty;

            // Remove any invalid characters
            foreach (var c in input)
            {
                if (MorseCodeLib.MorseCode.ContainsKey(c))
                {
                    cleanedInput += c;
                }
            }

            return string.Join(" ", cleanedInput.Select(x => MorseCodeLib.MorseCode[x])).TrimStart();
        }
    }
}