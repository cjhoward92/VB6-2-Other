using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace vb6.net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are starting");

            // if (args.Length < 1) {
            //     Console.WriteLine("You need a path");
            //     return;
            // }

            string path = @"F:\vb6\TestProj\Class1.cls"; //args[0];
            string text = null;
            using (var reader = new StreamReader(File.Open(path, FileMode.Open))) {
                text = reader.ReadToEnd();
            }

            var stream = new AntlrInputStream(text);
            var lexer = new VisualBasic6Lexer(stream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new VisualBasic6Parser(tokenStream);
            var ctx = parser.startRule();
            var treeWalker = new ParseTreeWalker();
            if (!parser.BuildParseTree) {
                throw new Exception("We are not built");
            }
            treeWalker.Walk(new VB6Listener(), ctx);
            Console.ReadKey();
        }
    }
}
