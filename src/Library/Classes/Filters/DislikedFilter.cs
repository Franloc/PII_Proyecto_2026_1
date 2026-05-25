namespace Library
{
    // Clase filtro que filtra por Disliked Media
    public class DislikedFilter : IFilter
    {
        public List<IMedia> Filter(User user, List<IMedia> list_to_filter, Type tipo)
        {
            List<IMedia> filtered_list = new List<IMedia>(); // Lista que va a returnear el método
            foreach (IMedia media in list_to_filter) // Recorre la lista que quiero filtrar
            {
                if (!user.Interactions.DisLikedMedia.Contains(media)) // Agrego a la lista filtrada solo los elementos que no estén en la lista de dislikes del usuario
                {
                    filtered_list.Add(media);
                }
            }
            return filtered_list;
        }
    }
}