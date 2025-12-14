namespace FlyweightPatternHelloWorld
{
  
    public class DocumentEditor(GlyphFactory glyphFactory)
    {

        private readonly GlyphFactory _glyphFactory = glyphFactory;

        private readonly List<(IGlyph glyph, int x, int y, int size, string color)> _characters = new();


        public void InsertCharacter(char character, string fontFamily, int x, int y, int size, string color)
        {
            IGlyph glyph = _glyphFactory.GetGlyph(character, fontFamily);

            Console.WriteLine($"Inserting character '{character}' with font '{fontFamily}' at ({x},{y}) with size {size} and color {color}");

            _characters.Add((glyph, x, y, size, color));
        }

        public void RenderDocument()
        {
            Console.WriteLine("Rendering Document...");

            foreach (var glyph in _characters)
            {
                glyph.glyph.Render(glyph.x, glyph.y, glyph.size, glyph.color);
            }
        }








    }
}
