using System.Data.Common;

namespace FlyweightPatternHelloWorld
{
    public class Glyph : IGlyph
    {

        private Guid _id = Guid.NewGuid();

        private readonly char _character;
        private readonly string _fontFamily;

        public Glyph(char character, string fontFamily)
        {
            _character = character;
            _fontFamily = fontFamily;

            Console.WriteLine($"Creating Glyph object for character '{character}' with font '{fontFamily}' , id : {_id.ToString("N")}");
        }

        public void Render(int x, int y, int size, string color)
        {
            //uses both the extinsic and intrinsic state to render the glyph
            Console.WriteLine($"Rendering character '{_character}' with font '{_fontFamily}' at ({x},{y}) with size {size} and color {color} , id : {_id.ToString("N")}");
        }

    }
}
