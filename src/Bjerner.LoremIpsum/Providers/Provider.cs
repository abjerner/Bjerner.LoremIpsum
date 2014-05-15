using System.Collections.Generic;
using System.Linq;

namespace Bjerner.LoremIpsum.Providers {
    
    public abstract class Provider {
        
        public abstract string PreText { get; }
        public abstract string[] Words { get; }

        public virtual string[] Fillers {
            get { return LoremIpsumConstants.Fillers; }
        }

        public virtual string[] GetWords(LoremIpsumType type) {
            return (type == LoremIpsumType.WordsAndFillers ? Words.Union(Fillers).ToArray() : Words).Shuffle();
        }

        public virtual string MakeSentence(LoremIpsumType type) {

            // A sentence should be bewteen 4 and 15 words.
            string sentence = "";
            int length = LoremIpsumGenerator.Next(4, 15);

            // Add a little more randomness to commas, about 2/3rds of the time
            bool includeComma = length >= 7 && LoremIpsumGenerator.Next(0, 2) > 0;

            string[] words = GetWords(type);

            if (words.Length > 0) {

                for (int i = 0; i < length; i++) {
                    if (i > 0) {
                        if (i >= 3 && i != length - 1 && includeComma) {
                            if (LoremIpsumGenerator.Next(0, 1) == 1) {
                                sentence = sentence.TrimEnd() + ", ";
                                includeComma = false;
                            } else {
                                sentence += " ";
                            }
                        } else {
                            sentence += " ";
                        }
                    }
                    sentence += words[i];
                }

                sentence = sentence.TrimEnd() + ".";

            }

            return sentence;

        }

        public virtual string[] MakeParagraph(LoremIpsumType type) {

            // A paragraph should be bewteen 4 and 7 sentences.

            List<string> temp = new List<string>();
            int length = LoremIpsumGenerator.Next(4, 7);

            for (int i = 0; i < length; i++) {
                temp.Add(MakeSentence(type));
            }

            return temp.ToArray();

        }

    }

}