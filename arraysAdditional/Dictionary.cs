
namespace arraysAdditional
{
    class Dictionary
    {
        private string[] valueRu = new string[5];
        private string[] valueEn = new string[5];
        private string[] valueFr = new string[5];

        public Dictionary()
        {
            valueRu[0] = "книга"; valueEn[0] = "book"; valueFr[0] = "livre";
            valueRu[1] = "ручка"; valueEn[1] = "pen"; valueFr[1] = "stylo";
            valueRu[2] = "солнце"; valueEn[2] = "sun"; valueFr[2] = "soleil";
            valueRu[3] = "яблоко"; valueEn[3] = "apple"; valueFr[3] = "pomme";
            valueRu[4] = "стол"; valueEn[4] = "table"; valueFr[4] = "table";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < valueRu.Length; i++)
                    if (valueRu[i] == index || valueEn[i] == index || valueFr[i] == index)
                        return valueRu[i] + " - " + valueEn[i] + " - "+ valueFr[i];

                return $"{index} - нет перевода для этого слова.";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < valueRu.Length)
                    return valueRu[index] + " - " + valueEn[index] + " - " + valueFr[index];
                
                return "Попытка обращения за пределы массива.";
            }
        }
    }
}
