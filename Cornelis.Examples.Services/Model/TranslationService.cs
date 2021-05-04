using Cornelis.Examples.Models.Common.Enums;
using Cornelis.Examples.Models.Core.Translation;
using Cornelis.Examples.Services.Interfaces;
using System.Collections.Generic;

namespace Cornelis.Examples.Services.Model
{
    public class TranslationService : ITranslationService
    {
        private Dictionary<Languages, ITranslator> LanguageLib { get; }

        public TranslationService()
        {
            // Add the possible languages
            LanguageLib = new Dictionary<Languages, ITranslator>();
            LanguageLib.Add(Languages.AyTalk, new AyTalkTranslator());
            LanguageLib.Add(Languages.LoremIpsum, new LoremIpsumTranslator());
            LanguageLib.Add(Languages.MorseCode, new MorseTranslator());
        }

        /// <summary>
        /// Translate between two languages
        /// </summary>
        /// <param name="languageFrom"></param>
        /// <param name="languageTo"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Translate(Languages languageFrom, Languages languageTo, string input)
        {
            // Null/Empty Check
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            if (languageFrom != Languages.English)
            {
                input = LanguageLib[languageFrom].TranslateFrom(input);

                // If it has to be translated into english then the process is done
                // and we can return the reult
                if (languageTo == Languages.English)
                {
                    return input;
                }
            }

            // Otherwise translate and return it.
            return LanguageLib[languageTo].TranslateTo(input);
        }
    }
}