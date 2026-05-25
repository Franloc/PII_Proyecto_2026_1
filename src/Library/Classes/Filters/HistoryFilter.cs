namespace Library
{
    // Clase filtro para filtrar por historial
    public class HistoryFilter : IFilter
    {
        public List<IMedia> Filter(User user, List<IMedia> list_to_recommend)
        {
            List<IMedia> filtered_list = new List<IMedia>();
            foreach (IMedia media in list_to_recommend)
            {
                if (!user.Interactions.History.Contains(media))
                {
                    filtered_list.Add(media);
                }
            }
            return filtered_list;
        }
    }
}