﻿using System.Collections.Generic;

namespace DBServer.Project.Data
{
    public class RestaurantData : IRestaurantData
    {
        public IEnumerable<RestaurantModel> GetRestaurants()
        {
            return new[]
            {
                new RestaurantModel()
                {
                    Id = 1,
                    Name = "Chefe do bairro",
                    ImageLink = null,
                    IsAvailable = false
                },
                new RestaurantModel()
                {
                    Id = 2,
                    Name = "Teste 2",
                    ImageLink = null,
                    IsAvailable = true
                },
                new RestaurantModel()
                {
                    Id = 3,
                    Name = "Teste 3",
                    ImageLink = null,
                    IsAvailable = true
                },
                new RestaurantModel()
                {
                    Id = 4,
                    Name = "Teste 4",
                    ImageLink = null,
                    IsAvailable = true
                }
            };
        }
    }
}