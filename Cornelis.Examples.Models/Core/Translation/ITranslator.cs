namespace Cornelis.Examples.Models.Core.Translation
{
    /// <summary>
    /// Interface for translators
    /// </summary>
    public interface ITranslator
    {
        /// <summary>
        /// Translates english to the given language
        /// </summary>
        /// <returns></returns>
        string TranslateTo(string input);

        /// <summary>
        /// Translates given language to english
        /// </summary>
        /// <returns></returns>
        string TranslateFrom(string input);
    }
}