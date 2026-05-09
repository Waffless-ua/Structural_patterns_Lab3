using ClassLibrary.Adapter;
using ClassLibrary.Bridge;
using ClassLibrary.Bridge.Shapes;
using ClassLibrary.Composite;
using ClassLibrary.Composite.Builder;
using ClassLibrary.Composite.Command;
using ClassLibrary.Composite.Iterator;
using ClassLibrary.Composite.Visitor;
using ClassLibrary.Decorator;
using ClassLibrary.Decorator.Heros;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //DemonstrateCompositor();
            //DemonstrateStrategy();
            //AdapterPrint();
            //DecoratorPrint();
            //BridgePrint();

            DemonstrateCommand();
            var element = DemonstrateBuilder();
            DemonstrateVisitor(element);
            DemonstrateIterator(element);
        }
        #region base tasks
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
        #endregion
        
        
        #region base compositor
        public static void DemonstrateCompositor()
        {
            var ul = new LightElementNode("ul", false);
            ul.AddClass("my-list");

            var li1 = new LightElementNode("li", false);
            li1.AddChild(new LightTextNode("Перший елемент"));

            var li2 = new LightElementNode("li", false);
            li2.AddChild(new LightTextNode("Другий елемент"));

            var li3 = new LightElementNode("li", false);
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

        static void DemonstrateStrategy()
        {
            var localImage = new LightImageNode("image.png");

            var webImage = new LightImageNode("https://example.com/image.jpg");

            Console.WriteLine("Light HTML");
            Console.WriteLine(localImage.OuterHTML());
            Console.WriteLine(webImage.OuterHTML());

            Console.WriteLine("\nLoading");
            Console.WriteLine(localImage.LoadImage());
            Console.WriteLine(webImage.LoadImage());
        }
        #endregion

        #region module work patterns
        static LightElementNode DemonstrateBuilder()
        {
            Console.WriteLine("--- Builder ---");
            ILightElementBuilder builder = new LightElementBuilder("div");

            LightElementNode element = builder
                    .AddClass("container")
                    .AddClass("mt-5")
                    .AddChild(
                        new LightElementBuilder("h1")
                            .AddClass("title")
                            .AddChild(new LightTextNode("Hello Builder"))
                            .Build()
                    )
                    .AddChild(
                        new LightElementBuilder("p")
                            .AddChild(new LightTextNode("This is paragraph"))
                            .Build()
                    )
                    .Build();

            Console.WriteLine(element.OuterHTML());

            return element;
        }
        static void DemonstrateVisitor(LightElementNode element)
        {
            Console.WriteLine("--- Visitor ---");
            HtmlStatisticsVisitor visitor = new();

            element.Accept(visitor);

            Console.WriteLine($"Elements: {visitor.ElementCount}");
            Console.WriteLine($"Text nodes: {visitor.TextNodeCount}");
            Console.WriteLine($"Text nodes: {visitor.ImagesCount}");
        }
        static void DemonstrateIterator(LightElementNode element)
        {
            Console.WriteLine("--- Iterator ---");

            ILightIterator iterator = new DepthFirstIterator(element);

            while (iterator.HasNext())
            {
                var node = iterator.Next();
                
                Console.WriteLine(node.OuterHTML());
            }
        }


        static void DemonstrateCommand()
        {
            Console.WriteLine("--- Command ---");

            var root = new LightElementNode("div", false);

            var manager = new CommandManager();

            var child = new LightElementNode("p", false);

            manager.ExecuteCommand(new AddChildCommand(root, child));

            manager.ExecuteCommand(new AddClassCommand(root, "container"));

            Console.WriteLine(root.OuterHTML());

            manager.Undo();
            manager.Undo();

            Console.WriteLine("After undo:");
            Console.WriteLine(root.OuterHTML());
        }

        #endregion


    }
}
