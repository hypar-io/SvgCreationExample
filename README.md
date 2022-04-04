

# SVG Creation Example

This function is an example of how to create an SVG Element, to display in Hypar's web interface. To use:

- Clone https://github.com/hypar-io/Elements.SVG/ and put adjacent to this project folder.
- Add a reference to the `SVGGraphic` type in your `element_types` in `hypar.json`
- Create an `SVG` using the `Elements.SVG` library.
- Create an `SVGGraphic` Element, containing your `SVG`'s markup.
- Add the `SVGGraphic` to the model output.
- In the Hypar web UI, create a "chart" from the elements table containing your SVG Graphic, which you'll find in the "Outputs" panel.
- Publish that chart as a widget to control size and positioning.

|Input Name|Type|Description|
|---|---|---|
|Length|number|The Length.|
|Width|number|The Width.|


<br>

|Output Name|Type|Description|
|---|---|---|
|Volume|Number|The volume.|

