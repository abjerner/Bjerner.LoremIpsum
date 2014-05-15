using System;
using System.Collections.Generic;
using System.Linq;
using Bjerner.LoremIpsum.Providers;

namespace Bjerner.LoremIpsum {
    
    public class LoremIpsumGenerator {

        #region Properties
        
        public Provider Provider { get; set; }

        #endregion

        #region Constructors

        public LoremIpsumGenerator() {
            Provider = new DefaultProvider();
        }

        public LoremIpsumGenerator(Provider provider) {
            Provider = provider;
        }

        #endregion

        public string[] GetWords(LoremIpsumType type) {
            return Provider.GetWords(type);
        }

        public string MakeSentence(LoremIpsumType type) {
            return Provider.MakeSentence(type).FirstCharToUpper();

        }

        public string[] MakeSentences(LoremIpsumType type = LoremIpsumType.WordsAndFillers, int numberOfSentences = 5, bool startWithLorem = true) {
            List<string> temp = new List<string>();
            for (int i = 0; i < numberOfSentences; i++) {
                string sentence = Provider.MakeSentence(type);
                if (i == 0 && startWithLorem) sentence = Provider.PreText + " " + sentence;
                temp.Add(sentence.FirstCharToUpper());
            }
            return temp.ToArray();
        }

        public string MakeParagraph(LoremIpsumType type) {
            return String.Join(" ", (
                from sentence in Provider.MakeParagraph(type)
                select sentence.FirstCharToUpper()
            ));
	    }

        public string[] MakeParagraphs(LoremIpsumType type = LoremIpsumType.WordsAndFillers, int numberOfParagraphs = 5, bool startWithLorem = true) {
            
            List<string> temp = new List<string>();
            
            for (int i = 0; i < numberOfParagraphs; i++) {

                // Get the paragraph as an array of sentences
                string[] sentences = Provider.MakeParagraph(type);

                // Could perhaps be prettier, but this makes sure that all sentences start with an
                // uppercase letter, and not convert an already uppercase letter to lowercase when
                // prepending the pre text.
                for (int j = 0; j < sentences.Length; j++) {
                    if (i == 0 && j == 0) {
                        sentences[j] = Provider.PreText + " " + sentences[j];
                    }
                    sentences[j] = sentences[j].FirstCharToUpper();
                }

                // Join the sentences into a single string
                temp.Add(String.Join(" ", sentences));
            
            }
            
            return temp.ToArray();

        }

        public static readonly Random Random = new Random();

        public static int Next(int min, int max) {

            // Using the Random class might not give very random numbers, so
            // you can change the logic here, and it will have effect
            // throughout the generator.

            return Random.Next(min, max);

        }

    }

}
