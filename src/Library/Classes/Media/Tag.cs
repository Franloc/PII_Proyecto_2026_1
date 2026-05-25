namespace Library
{
    //Clase que guarda informacion sobre una caracteristica especifica del Media.
    public class Tag
    {
        private string name;
        public string Name
        {
            get {return this.name;} set {this.name = value;}
        }

        //Constructor
        public Tag(string name)
        {
            this.name = name;
        }
    }
}