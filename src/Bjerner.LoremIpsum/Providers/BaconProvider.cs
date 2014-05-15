namespace Bjerner.LoremIpsum.Providers {

    /// <summary>
    /// Bacon flavored provider (based on http://baconipsum.com/)
    /// </summary>
    public class BaconProvider : Provider {
        
        public override string PreText {
            get { return "Bacon ipsum dolor sit amet"; }
        }

        public override string[] Words {
            get {
                return new[] {
                    "beef",
                    "chicken",
                    "pork",
                    "bacon",
                    "chuck",
                    "short loin",
                    "sirloin",
                    "shank",
                    "flank",
                    "sausage",
                    "pork belly",
                    "shoulder",
                    "cow",
                    "pig",
                    "ground round",
                    "hamburger",
                    "meatball",
                    "tenderloin",
                    "strip steak",
                    "t-bone",
                    "ribeye",
                    "shankle",
                    "tongue",
                    "tail",
                    "pork chop",
                    "pastrami",
                    "corned beef",
                    "jerky",
                    "ham",
                    "fatback",
                    "ham hock",
                    "pancetta",
                    "pork loin",
                    "short ribs",
                    "spare ribs",
                    "beef ribs",
                    "drumstick",
                    "tri-tip",
                    "ball tip",
                    "venison",
                    "turkey",
                    "biltong",
                    "rump",
                    "jowl",
                    "salami",
                    "bresaola",
                    "meatloaf",
                    "brisket",
                    "boudin",
                    "andouille",
                    "capicola",
                    "swine",
                    "kielbasa",
                    "frankfurter",
                    "prosciutto",
                    "filet mignon",
                    "leberkas",
                    "turducken",
                    "doner",
                    "kevin",
                    "landjaeger",
                    "porchetta"
                };
            }
        }
    
    }

}