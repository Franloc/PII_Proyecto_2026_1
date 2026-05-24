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
        private List<IMedia> viewedMedia;
        public List<IMedia> ViewedMedia
        {
            get {return this.viewedMedia;} set {this.viewedMedia = value;}
        }



        //Constructor
        public UserInteractions()
        {
        }
    }
}