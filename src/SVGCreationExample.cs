using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace SVGCreationExample
{
    public static class SVGCreationExample
    {
        /// <summary>
        /// The SVGCreationExample function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A SVGCreationExampleOutputs instance containing computed results and the model with any new elements.</returns>
        public static SVGCreationExampleOutputs Execute(Dictionary<string, Model> inputModels, SVGCreationExampleInputs input)
        {
            var output = new SVGCreationExampleOutputs();
            // create an SVG document
            var svg = new SVG();

            // Add geometry, and declare style inline
            svg.AddGeometry(new Circle((50, 50), 50).ToPolygon(50), null, new SVG.Style { Stroke = "black", Fill = null, StrokeWidth = 2 });

            // Create styles and associate them with classes for terser expression
            svg.AddStyle(".red-fill", new SVG.Style { Fill = Colors.Red, StrokeWidth = 1, Stroke = "#ff4422" });
            svg.AddGeometry(Polygon.Rectangle((200, 0), (300, 100)), "red-fill");

            // Add text
            svg.AddText((150, 50), "I'm text", null, "middle", new SVG.Style { Fill = Colors.Cobalt, Stroke = null });


            output.Model.AddElement(new SVGGraphic(svg.SvgString()));
            return output;
        }
    }
}