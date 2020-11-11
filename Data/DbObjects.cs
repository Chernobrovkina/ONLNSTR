using BeautySPA.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONLNSTR.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Watch.Any())
            {
                content.AddRange(
                     new Watch
                    {
                        name = "Earnshaw Diamonds",
                        parameter = "Бренд Locman Артикул/модель 0810B02S-BLBLWHSB Стекло Минеральное",
                        description = "Женские кварцевые часы. Центральные часовая, минутная и секундная стрелки. Черный циферблат украшен кристаллами Swarovski",
                        img = "/img/a202b967-ff67-4964-b999-053ada1ca3c5.png",
                        price = 2490,
                        favourites = true,
                        available = true,
                        Category = Categories["Женские часы"]
                     },
                    new Watch
                    {
                        name = "Apple Watch SE",
                        parameter = "Корпус 44 мм или 40 мм" +
                        "Дисплей Retina" +
                        "Уведомления о слишком низком и высоком пульсе" +
                        "Защита от воды на глубине до 50 м1",
                        description = "Большой дисплей Retina, на котором поместится всё, что нужно. " +
                        "Продвинутые датчики для отслеживания любой физической активности. " +
                        "Полезные функции, которые помогают следить за показателями здоровья и заботятся о вашей безопасности. " +
                        "Apple Watch SE — часы, с которыми вы оцените каждую секунду.",
                        img = "/img/watch-compare-s3-202009.jpg",
                        price = 24990,
                        favourites = true,
                        available = true,
                        Category = Categories["Мужские часы"]
                        
                    }
                    );
            }

            content.SaveChanges();
               

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                         new Category { categoryName = "Женские часы", description = "В настоящее время наручные часы являются неотъемлемым модным аксессуаром женского образа"},
                    new Category { categoryName = "Мужские часы", description = "Обзор наручных мужских часов позволяет выбрать подходящее изделие, которое будет выполнять не только свое предназначение, но и станет ярким элементом стиля владельца." }
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    category.Add(el.categoryName,el);
                }return category;
            }
        }
            
    }
}
