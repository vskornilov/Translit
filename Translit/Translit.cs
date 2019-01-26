﻿using System.Collections.Generic;

namespace Translit
{
    public class Translit
    {

        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"а", "a"},
            {"А", "A" },

            {"б", "b"},
            {"Б", "B" },

            {"в", "v"},
            {"В", "V"},

            {"г", "g"},
            {"Г", "G"},

            {"д", "d"},
            {"Д", "D"},

            {"е", "e"},
            {"Е", "E"},

            {"ё", "e"},
            {"Ё", "E"},

            {"ж", "zh"},
            {"Ж", "Zh"},

            {"з", "z"},
            {"З", "Z"},

            {"и", "i"},
            {"И", "I"},

            {"й", "j"},
            {"Й", "J"},

            {"к", "k"},
            {"К", "K"},

            {"л", "l"},
            {"Л", "L"},

            {"м", "m"},
            {"М", "M"},

            {"н", "n"},
            {"Н", "N"},

            {"о", "o"},
            {"О", "O"},

            {"п", "p"},
            {"П", "P"},

            {"р", "r"},
            {"Р", "R"},

            {"с", "s"},
            {"С", "S"},

            {"т", "t"},
            {"Т", "T"},

            {"у", "u"},
            {"У", "U"},

            {"ф", "f"},
            {"Ф", "F"},

            {"х", "kh"},
            {"Х", "Kh"},

            {"ц", "ts"},
            {"Ц", "Ts"},

            {"ч", "ch"},
            {"Ч", "Ch"},

            {"ш", "sh"},
            {"Ш", "Sh"},

            {"щ", "shch"},
            {"Щ", "Shch"},

            {"ъ", ""},
            {"Ъ", ""},

            {"ы", "y"},
            {"Ы", "Y"},

            {"ь", "'"},
            {"Ь", "'"},

            {"э", "eh"},
            {"Э", "Eh"},

            {"ю", "yu"},
            {"Ю", "Yu"},

            {"я", "ya"},
            {"Я", "Ya"},

            {"a", "а"},
            {"A", "А"},

            {"b", "б"},
            {"B", "Б"},

            {"v", "в"},
            {"V", "В"},

            {"g", "г"},
            {"G", "Г"},

            {"d", "д"},
            {"D", "Д"},

            {"e", "е"},
            {"E", "Е"},

            {"zh", "ж"},
            {"Zh", "Ж"},

            {"z", "з"},
            {"Z", "З"},

            {"i", "и"},
            {"I", "И"},

            {"j", "й"},
            {"J", "Й"},

            {"k", "к"},
            {"K", "К"},

            {"l", "л"},
            {"L", "Л"},

            {"m", "м"},
            {"M", "М"},

            {"n", "н"},
            {"N", "Н"},

            {"o", "о"},
            {"O", "О"},

            {"p", "п"},
            {"P", "П"},

            {"r", "р"},
            {"R", "Р"},

            {"s", "с"},
            {"S", "С"},

            {"t", "т"},
            {"T", "Т"},

            {"u", "у"},
            {"U", "У"},

            {"f", "ф"},
            {"F", "Ф"},

            {"kh", "х"},
            {"Kh", "Х"},

            {"ts", "ц"},
            {"Ts", "Ц"},

            {"ch", "ч"},
            {"Ch", "Ч"},

            {"sh", "ш"},
            {"Sh", "Ш"},

            {"shch", "щ"},
            {"Shch", "Щ"},

            {"y", "ы"},
            {"Y", "Ы"},

            {"eh", "э"},
            {"Eh", "Э"},

            {"yu", "ю"},
            {"Yu", "Ю"},

            {"ya", "я"},
            {"Ya", "Я"},

            {"q", "к"},
            {"Q", "К"},

            {"w", "в"},
            {"W", "В"},

            {"h", "x"},
            {"H", "X"}
        };

        public string TrRusEng(string source)
        {
            var result = "";
            
            foreach (var ch in source)
            {
                var ss = "";
                
                if (dictionary.TryGetValue(ch.ToString(), out ss))
                {
                    result += ss;
                }
                
                else result += ch;
            }
            return result;
        }

    }

}