using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                // in the runtime, the shape can be any object derived from the shape
                // in runtime, if shape is circle, then draw method of circle will be called
                shape.Draw();
            }
        }
    }
}
