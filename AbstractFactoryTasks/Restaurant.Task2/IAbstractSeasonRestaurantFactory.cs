using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Task2
{
    /// <summary>
    /// Interface for factory entity
    /// </summary>
    interface IAbstractSeasonRestaurantFactory
    {
        IRecity CreateMasala();
    }
}
