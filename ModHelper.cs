using System;

namespace ICantBelieveItsNotVanilla
{
    public static class ModHelper
    {
        public static string Tooltip(params string[] text)
        {
            return string.Join(Environment.NewLine, text);
        }
    }
}
