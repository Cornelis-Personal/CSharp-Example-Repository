using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cornelis.Examples.Models.Core.Translation
{
    /// <summary>
    /// Tranlates Ay talk
    /// </summary>
    public class AyTalkTranslator : ITranslator
    {
        public string TranslateFrom(string input)
        {
            // Split the string into words
            var splits = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string output = string.Empty;

            foreach (var split in splits)
            {
                // Correct the word
                var subSplit = split.Split('-');

                // If it cannot be split again it is an invalid word and we will ignore it
                if (subSplit.Count() > 1)
                {
                    var word = subSplit[1][0] + subSplit[0];

                    output = string.Join(" ", output, word);
                }
            }

            return output.TrimStart();
        }

        public string TranslateTo(string input)
        {
            // Split the string into words
            var splits = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string output = string.Empty;

            foreach (var split in splits)
            {
                string backpart = "-" + split[0] + "ay";
                string frontpart = string.Empty;

                // handle multiple letter words
                if (split.Length > 1)
                {
                    frontpart = split.Substring(1, split.Length - 1);
                    output = string.Join(" ", output, frontpart + backpart);
                }
                else // handle single letter words
                {
                    output = string.Join(" ", output, backpart);
                }
            }

            return output.TrimStart();
        }
    }
}