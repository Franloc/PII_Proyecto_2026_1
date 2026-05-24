namespace Library
{
    public class Interaction
    {
        private User user;
        public User User
        {
            get {return this.user;} set {this.user = value;}
        }
        private IMedia media;
        public IMedia Media
        {
            get {return this.media;} set {this.media = value;}
        }
        private InteractionType type;
        public InteractionType Type
        {
            get {return this.type;} set {this.type = value;}
        }
        public Interaction(User user, IMedia media, InteractionType type)
        {
            this.user = user;
            this.media = media;
            this.type = type;
        }
    }
}