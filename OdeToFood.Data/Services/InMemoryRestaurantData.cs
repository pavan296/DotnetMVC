using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
                {
                    new Restaurant{Id=1 , Name="Scott-Pizza" , Cuisine=CuisineType.Italian},
                    new Restaurant{Id=2 , Name="Masala-dosa" , Cuisine=CuisineType.Indian},
                    new Restaurant{Id=3 , Name="idli" , Cuisine=CuisineType.French}
                    //new Restaurant{Id=4 , Name="puliyogre" , Cuisine=CuisineType.None}
                };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
