namespace EfsTools.Layouts
{
    internal class TextLayoutRule : ILayoutRule
    {
        public TextLayoutRule(string text)
        {
            _text = text;
        }

        private readonly string _text;
        
        public string Render()
        {
            return _text;
        }
    }
}
