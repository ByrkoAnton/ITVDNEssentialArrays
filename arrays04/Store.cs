using System;
using System.Collections.Generic;
using System.Text;

namespace arrays04
{
    class Store
    {
        private Article[] articles;

        public Store()
        {
            articles = new Article[]
            {
                new Article("Phone", "Eldorado", 100),
                new Article("Table", "Table World", 200),
                new Article("Window", "Best Widows", 80),
                new Article("Boots", "Timberland", 30),
                new Article("Scoup", "Optic Planet", 180)
            };
        }
        public string this[string itemName]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].itemName == itemName)
                        return $"{articles[i].itemName}\n{articles[i].shopName}\n{articles[i].prise}\n";
                }

                return "This item is out of stock";
            }
        }
        public string this[int itemPos]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (i == itemPos)
                        return $"{articles[i].itemName}\n{articles[i].shopName}\n{articles[i].prise}\n";
                }

                return "No item in this position";
            }
        }
    }
}
