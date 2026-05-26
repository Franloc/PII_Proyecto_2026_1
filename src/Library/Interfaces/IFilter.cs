using System;
using System.Collections.Generic;

namespace Library
{
    public interface IFilter // Interfaz de los filtros
    {
        List<IMedia> Filter(User user, List<IMedia> media, Type tipo);
    }
}