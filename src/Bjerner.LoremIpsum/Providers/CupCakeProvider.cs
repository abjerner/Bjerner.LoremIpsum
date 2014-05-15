namespace Bjerner.LoremIpsum.Providers {

    /// <summary>
    /// Cupcake flavoured provider (based on http://www.cupcakeipsum.com/)
    /// </summary>
    public class CupCakeProvider : Provider {
        
        public override string PreText {
            get { return "Cupcake ipsum dolor sit amet"; }
        }

        public override string[] Words {
            get {
                return new[] {
                    "jelly-o",
                    "croissant",
                    "biscuit",
                    "chocolate",
                    "cake",
                    "gummi",
                    "bears",
                    "bear",
                    "claw",
                    "cupcake",
                    "pastry",
                    "apple",
                    "pie",
                    "jelly",
                    "wafer",
                    "sesame",
                    "snaps",
                    "sugar",
                    "plum",
                    "sweet",
                    "roll",
                    "applicake",
                    "marzipan",
                    "dragée",
                    "cotton",
                    "candy",
                    "marshmallow",
                    "caramels",
                    "dessert",
                    "danish",
                    "halvah",
                    "lemon",
                    "drops",
                    "cookie",
                    "lollipop",
                    "chupa",
                    "chups",
                    "carrot",
                    "canes",
                    "toffee",
                    "gummies",
                    "brownie",
                    "powder",
                    "bar",
                    "beans",
                    "ice",
                    "cream",
                    "unerdwearcom",
                    "tiramisu",
                    "tootsie",
                    "icing",
                    "bonbon",
                    "macaroon",
                    "fruitcake",
                    "cheesecake",
                    "soufflé",
                    "donut",
                    "oat",
                    "topping",
                    "gingerbread",
                    "pudding",
                    "liquorice",
                    "jujubes",
                    "tart"
                };
            }
        }
    
    }

}