namespace Library
{
    public class User
    {
        private string name;
        public string Name
        {
            get {return this.name;} set {this.name=value;}
        }

        private List<Tag> preferences;
        public List<Tag> Preferences
        {
            get {return this.preferences;} set {this.preferences=value;}
        }

        private UserInteractions interactions;
        public UserInteractions Interactions
        {
            get {return this.interactions;} set {this.interactions = value;}
        }

        //Constructor
        public User(string name)
        {
            this.name = name;
            preferences = new List<Tag>();
            interactions = new UserInteractions();
        }
    }
}