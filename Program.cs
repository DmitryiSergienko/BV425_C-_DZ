using BV425_C__DZ.Bridge.Classes;
using BV425_C__DZ.Flyweight.Classes;

Console.WriteLine("Паттерн \"Мост\" (Bridge)\n" +
    "Пример: Рендеринг фигур с различными цветами");

var svgRenderer = new SvgRenderer();
var canvasRenderer = new CanvasRenderer();

var circle = new Circle(svgRenderer);
circle.Draw();

var rectangle = new Rectangle(canvasRenderer);
rectangle.Draw();

///////////////////////////////////////////////////////////////////

Console.WriteLine("\n===========================================\n" +
    "Паттерн \"Легковес\" (Flyweight)\n" +
    "Пример: Управление символами в текстовом редакторе");

var factory = new CharacterFactory();
var editor = new TextEditor(factory);

editor.AddCharacter('A', 0);
editor.AddCharacter('B', 1);
editor.AddCharacter('A', 2); // 'A' уже существует, будет использован существующий легковес
editor.AddCharacter('C', 3);

editor.Display();