namespace Library
{
    public class Song: IMedia
    {
        //Atributos
        private string name;
        public string Name
        {
            get {return this.name;} set {this.name = value;}
        }
        private float calification;
        public float Calification
        {
            get {return this.calification;}
        }

        private List<Tag> tags {get;}
        public List<Tag> Tags {get;}

        //Constructor
        public Song(string name)
        {
            this.name = name;
        }
    }
}