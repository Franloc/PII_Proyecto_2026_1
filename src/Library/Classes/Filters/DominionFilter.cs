namespace Library
{
    // Clase filtro que filtra por Disliked Media
    public class DominionFilter : IFilter
    {
        public List<IMedia> Filter(User user, List<IMedia> list_to_filter, Type tipo)
        {
            List<IMedia> filtered_list = new List<IMedia>(); // Lista que va a devolver el método
            for (int i=0; i < list_to_filter.Count; i++) // Recorre la lista que quiero filtrar
            {
                if (list_to_filter[i].GetType() == tipo)
                {
                    filtered_list.Add(list_to_filter[i]);
                }
            
            }
            return filtered_list;
        }
    }
}