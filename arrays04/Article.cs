using System;
using System.Collections.Generic;
using System.Text;

namespace arrays04
{
    class Article
    {
        private string _itemName;
        private string _shopName;
        private int _prise;

        public Article(string itemName, string shopName, int prise)
        {
            _prise = prise;
            _itemName = itemName;
            _shopName = shopName;
        }

        public string itemName => _itemName;
        public string shopName => _shopName;
        public int prise => _prise;
    }

    
}
