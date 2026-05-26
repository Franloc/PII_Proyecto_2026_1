using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class PreferenceRankingStrategy : IRankingStrategy
    {
        public List<IMedia> Rank(User user, List<IMedia> list_to_rank)
        {
            //Devuelve la lista ordenada. Evalúa la cantidad de tags de cada media y calcula cuántos tiene en común con los establecidos en la
            //preferencia del usuario, usa ese número para ordenar la lista de forma descendiente. Por lo tanto, los ítems que mejor se acercan a las preferencias del usuario
            //son los que se encuentran al principio de la lista
            return list_to_rank.OrderByDescending(item => item.Tags.Count(tag => user.Preferences.Contains(tag))).ToList();
        }
    }
}