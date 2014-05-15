using System;

namespace Bjerner.LoremIpsum {

    internal static class LoremIpsumExtensionMethods {

        public static string FirstCharToUpper(this string input) {
            return String.IsNullOrEmpty(input) ? "" : String.Concat(input.Substring(0, 1).ToUpper(), input.Substring(1));
        }

        /// <see cref="http://stackoverflow.com/questions/1866533/returning-items-randomly-from-a-collection#1866558" />
        public static string[] Shuffle(this string[] array) {
            for (int n = 0; n < array.Length; n++) {
                int k = LoremIpsumGenerator.Next(n, array.Length);
                string temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
            return array;
        }
    
    }

}
