using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Task1
{
    /// <summary>
    /// Interface for factory entity
    /// </summary>
    interface IAbstractRestaurantFactory
    {
        IMasala CreateMasala();
    }
}
