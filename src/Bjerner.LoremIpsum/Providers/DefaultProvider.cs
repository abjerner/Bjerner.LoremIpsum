namespace Bjerner.LoremIpsum.Providers {

    public class DefaultProvider : Provider {
        
        public override string PreText {
            get { return "Lorem ipsum dolor sit amet"; }
        }

        public override string[] Words {
            get {
                return base.Fillers;
            }
        }

        public override string[] Fillers {
            get {
                return new string[0];
            }
        }
    
    }

}