using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shopping_app.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_app.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Stylish and Cool",
                        longDesc = "Very comfortable car for citylife",
                        img = "https://www.driven.co.nz/media/100002322/e46.jpg?width=820",
                        price = 65000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Classic Cars"]
                    },
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Very fast car",
                        longDesc = "Beautiful, fast and very quite car by Tesla company",
                        img = "https://upload.wikimedia.org/wikipedia/commons/1/14/2018_Tesla_Model_S_75D.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Electric Cars"]
                    },
                    new Car
                    {
                        name = "Mercedes C Class",
                        shortDesc = "Very comfortable and spacious",
                        longDesc = "Comfortable car for citylife",
                        img = "https://www.mercedes-benz.co.nz/passengercars/mercedes-benz-cars/models/c-class/saloon/inspiration/highlights/_jcr_content/contentgallerycontainer/par/contentgallery_5e99/par/contentgallerytile_5/image.MQ6.8.20180830163625.jpeg",
                        price = 40000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Classic Cars"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Economical and quite",
                        longDesc = "Handful car for citylife",
                        img = "https://cleantechnica.com/files/2018/06/DSC1231-1-e1528974986458.jpg?width=1200&enable=upscale",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Electric Cars"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Quite and cool",
                        longDesc = "Very comfortable car for citylife",
                        img = "https://www.driven.co.nz/media/100005871/281019nzhmhfst02.jpg?width=820",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Classic Cars"]
                    }
                
                    
                );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if( category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Electric Cars", descripttion = "Modern and eco friendly type of cars"},
                        new Category { categoryName = "Classic Cars", descripttion = "Cars with diesel engines"}
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category element in list)
                        category.Add(element.categoryName, element);
                }

                return category;
            }
        }
    }
}
