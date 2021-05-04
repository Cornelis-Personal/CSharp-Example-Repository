using Cornelis.Examples.Models.Common.Enums;

namespace Cornelis.Examples.Services.Interfaces
{
    public interface ITranslationService
    {
        string Translate(Languages languageFrom, Languages languageTo, string input);
    }
}