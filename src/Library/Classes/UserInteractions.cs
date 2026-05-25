namespace Library
{
    public class UserInteractions
    {
        //Lista de objetos con los que se interactuo.
        private List<IMedia> likedMedia;
        public List<IMedia> LikedMedia
        {
            get {return this.likedMedia;} set {this.likedMedia = value;}
        }
        private List<IMedia> disLikedMedia;
        public List<IMedia> DisLikedMedia
        {
            get {return this.disLikedMedia;} set {this.disLikedMedia = value;}
        }
        private List<IMedia> history; //Aca forma parte lo que ya se recomendo
        public List<IMedia> History
        {
            get {return this.history;} set {this.history = value;}
        }

        //Constructor
        public UserInteractions()
        {
            likedMedia = new List<IMedia>();
            disLikedMedia = new List<IMedia>();
            history = new List<IMedia>();
        }
    }
}