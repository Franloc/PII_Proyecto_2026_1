using System;
using System.Collections.Generic;

namespace Library
{
    // Clase filtro para filtrar por historial
    public class HistoryFilter : IFilter
    {
        public List<IMedia> Filter(User user, List<IMedia> list_to_filter, Type tipo)
        {
            List<IMedia> filtered_list = new List<IMedia>(); // Lista que va a returnear el código
            foreach (IMedia media in list_to_filter) // Recorro la lista a filtrar
            {
                if (!user.Interactions.History.Contains(media)) // Agrego a la lista filtrada solo la media que no esté en el historial del usuario (la que no vió todavía)
                {
                    filtered_list.Add(media);
                }
            }
            return filtered_list;
        }
    }
}