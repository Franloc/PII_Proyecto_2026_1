namespace Library
{
    public class InteractionType
    {
        private string name;
        public string Name
        {
            get {return this.name;} set {this.name=value;}
        }
        public InteractionType(string name)
        {
            this.name=name;
        }
    }
}