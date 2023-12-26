using System.Collections.Generic;
using System;

namespace WebApplication1.Models
{
    public class ListViewModelClass
    {
        public class ListViewModel<T> : List<T> where T : class
        {
            public int TotalPages { get; set; }
            public int CurrentPage { get; set; }
            private ListViewModel(IEnumerable<T> items,
            int total,
            int current) : base(items)
            {
                TotalPages = total;
                CurrentPage = current;
            }
            /// <summary>
            /// Получить модель представления списка объектов
            /// </summary>
            /// <param name="list">исходный список объектов</param>
            /// <param name="current">номер текущей страницы</param>
            /// <param name="itemsPerPage">кол. объектов на странице</param>
            /// <returns>объект класса ListViewModel</returns>

          
               
            }
        }
    }
