using ClassLibrary.Adapter;
using ClassLibrary.Bridge;
using ClassLibrary.Bridge.Shapes;
using ClassLibrary.Decorator;
using ClassLibrary.Composite;
using ClassLibrary.Decorator.Heros;
using System.Text;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //AdapterPrint();
            //DecoratorPrint();
            //BridgePrint();
            DemonstrateCompositor();
        }

        public static void AdapterPrint()
        {
            Console.WriteLine("AdapterPrint\n");
            Console.WriteLine("Check file");
            var path = "C:\\Users\\zontu\\Documents\\Study\\2k_2s\\SoftwareDesign\\Lab3\\file.txt";


            IFileWriter fw = new FileWriter(path);
            ILogger logger = new Logger();

            logger = new LoggerAdapter(fw);
            logger.Warn("Попередження 1");
            logger.Error("Помилка 2");
            logger.Log("Лог 3");

            Console.WriteLine("");
        }

        public static void DecoratorPrint()
        {
            Console.WriteLine("DecoratorPrint\n");

            IHero warrior = new Warrior();
            IHero mage = new Mage();
            IHero paladin = new Paladin();

            warrior = new Artifact(new Artifact(new Artifact(new Artifact(new Helmet(new Armor(warrior))))));
            warrior.GetStats();

            mage = new Helmet(new Artifact(mage));
            mage.GetStats();

            paladin = new Armor(new Helmet(paladin));
            paladin.GetStats();

            Console.WriteLine();
        }

        public static void BridgePrint()
        {
            Console.WriteLine("BridgePrint\n");

            IRenderer vector = new VectorRenderer();
            IRenderer raster = new RasterRenderer();

            Shape circle = new Circle(vector);
            Shape square = new Square(raster);
            Shape triangle = new Triangle(raster);

            circle.Draw();
            square.Draw();
            triangle.Draw();

            Shape anotherTriangle = new Triangle(vector);
            anotherTriangle.Draw();

            Console.WriteLine();
        }

        public static void DemonstrateCompositor()
        {
            var ul = new LightElementNode("ul", true, false);
            ul.AddClass("my-list");

            var li1 = new LightElementNode("li", false, false);
            li1.AddChild(new LightTextNode("Перший елемент"));

            var li2 = new LightElementNode("li", false, false);
            li2.AddChild(new LightTextNode("Другий елемент"));

            var li3 = new LightElementNode("li", false, false);
            li3.AddChild(new LightTextNode("Третій елемент"));

            ul.AddChild(li1);
            ul.AddChild(li2);
            ul.AddChild(li3);

            Console.WriteLine("OuterHTML:");
            Console.WriteLine(ul.OuterHTML());

            Console.WriteLine("\nInnerHTML:");
            Console.WriteLine(ul.InnerHTML());

            Console.WriteLine("\nКількість дочірніх елементів: " + ul.ChildCount());
        }
    }
}
