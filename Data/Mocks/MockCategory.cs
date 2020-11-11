using BeautySPA.Data.Interfaces;
using BeautySPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ONLNSTR.Data.Mocks
{
    public class MockCategory :IWatchesCatecory
    {
        public IEnumerable <Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category { categoryName = "Женские часы", description = "В настоящее время наручные часы являются неотъемлемым модным аксессуаром женского образа"},
                    new Category { categoryName = "Мужские часы", description = "Обзор наручных мужских часов позволяет выбрать подходящее изделие, которое будет выполнять не только свое предназначение, но и станет ярким элементом стиля владельца." } 
                };
            }
        }
    }
}
