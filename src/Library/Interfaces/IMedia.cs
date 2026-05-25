namespace Library
{
    public interface IMedia //Interfaz de Media
    {
        string Name {get;}
        double Calification {get;}
        List<Tag> Tags {get;}
    }
}