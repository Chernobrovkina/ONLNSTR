using BeautySPA.Data.Interfaces;
using BeautySPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ONLNSTR.Data.Mocks;

namespace ONLNSTR.Data.Mocks
{
    public class MockWatch : IAllWatches
    {
        private readonly IWatchesCatecory _CatecoryWatches = new MockCategory();
        public IEnumerable<Watch> watches {
            get {
                return new List<Watch>
                {
                    new Watch
                    {
                        name = "Earnshaw Diamonds",
                        parameter = "Бренд Locman Артикул/модель 0810B02S-BLBLWHSB Стекло Минеральное",
                        description = "Женские кварцевые часы. Центральные часовая, минутная и секундная стрелки. Черный циферблат украшен кристаллами Swarovski",
                        img = "/img/a202b967-ff67-4964-b999-053ada1ca3c5.png",
                        price = 2490,
                        favourites = true,
                        available = true,
                        Category = _CatecoryWatches.AllCategories.First()
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
                        Category = _CatecoryWatches.AllCategories.First() }

                    };

            }
        } 
        public IEnumerable<Watch> GetFavWatches { get ; set; }

        public Watch GetObWatch(int Watchid)
        {
            throw new NotImplementedException();
        }
    }
}
