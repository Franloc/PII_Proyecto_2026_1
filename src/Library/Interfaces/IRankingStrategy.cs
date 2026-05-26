using System.Collections.Generic;

namespace Library
{
    public interface IRankingStrategy //Interfaz de las estrategias de ordenamiento
    {
        List<IMedia> Rank(User user, List<IMedia> media);
    }
}