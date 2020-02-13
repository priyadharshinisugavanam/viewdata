using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Entity;

namespace Restaurant.DAL
{
    public class RestaurantRepositary
    {
       static  List<RestaurantEntity> restaurantEntities = new List<RestaurantEntity>();

        static RestaurantRepositary()
        {
            RestaurantEntity restaurantEntity = new RestaurantEntity("Chennise", "Indian", "Sarada college,Salem");
            restaurantEntities.Add(restaurantEntity);
            restaurantEntity = new RestaurantEntity("Taj", "Chinese", "Bus-Stand,Erode");
            restaurantEntities.Add(restaurantEntity);
        }
        public IEnumerable<RestaurantEntity> DisplayRestaurant()
        {
            return restaurantEntities;
        }
    }
}
