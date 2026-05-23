namespace Library
{
    public class User
    {
        private string name;
        public string Name
        {
            get {return this.name;} set {this.name=value;}
        }
        private List<Tag> preferencias;
        public List<Tag> Preferencias
        {
            get {return this.preferencias;} set {this.preferencias=value;}
        }
        public User(string name)
        {
            this.name = name;
            preferencias = new List<Tag>();
        }
    }
}