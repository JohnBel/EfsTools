namespace EfsTools.Layouts
{
    internal class TextLayoutRule : ILayoutRule
    {
        private readonly string _text;

        public TextLayoutRule(string text)
        {
            _text = text;
        }

        public string Render()
        {
            return _text;
        }
    }
}