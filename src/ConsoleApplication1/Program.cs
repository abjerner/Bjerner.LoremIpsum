using System;
using Bjerner.LoremIpsum;
using Bjerner.LoremIpsum.Providers;

namespace ConsoleApplication1 {
    
    public class Program {
        
        public static void Main(string[] args) {

            LoremIpsumGenerator generator = new LoremIpsumGenerator(new UmbracoProvider());

            Console.WindowHeight = 50;

            foreach (string str in generator.MakeSentences()) {
                Console.WriteLine(str);
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (string str in generator.MakeParagraphs()) {
                Console.WriteLine();
                Console.WriteLine(str);
                Console.WriteLine();
            }

            return;

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("--" + generator.MakeParagraph(LoremIpsumType.WordsAndFillers) + "--");
                Console.WriteLine();
            }

        }
    
    }

}
