using Cornelis.Examples.Models.Libraries;
using System;

namespace Cornelis.Examples.Models.Core.Translation
{
    public class LoremIpsumTranslator : ITranslator
    {
        public string TranslateFrom(string input) => TranslateTo(input);

        /// <summary>
        /// Translate input text to lorem ipsum
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string TranslateTo(string input)
        {
            string output = string.Empty;

            foreach (var word in LoremIpsumLib.LoremIpsum.Split(" ", StringSplitOptions.RemoveEmptyEntries))
            {
                // Return the output if it is bigger or equals than the required length
                if (output.Length >= input.Length)
                    return output.TrimStart();

                output = string.Join(" ", output, word);
            }

            return output.TrimStart();
        }
    }
}