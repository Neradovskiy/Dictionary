using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    [Serializable]
    class Languages
    {
        public readonly string Rus = "Русский";
        public readonly string Eng = "English";
    }
    [Serializable]
    class Word
    {
        public Word(string origWord, string transl)
        {
            if (translate == null)
                translate = new List<string>();
            originWord = origWord.ToLower();
            translate.Add(transl.ToLower());
        }

        public Word(string origWord, List<string> transl)
        {
            originWord = origWord.ToLower();
            translate = transl;
        }

        public Word(Word word)
        {
            originWord = word.originWord;
            translate = word.translate;
        }
        public void AddTranlate(string transl)
        {
            if (!translate.Contains(transl.ToLower()))
                translate.Add(transl.ToLower());
        }
        public string originWord { get; set; }
        public List<string> translate { get; }

        public static bool operator==(Word lhs, Word rhs)
        {
            return lhs.originWord == rhs.originWord;
        }

        public static bool operator != (Word lhs, Word rhs)
        {
            return !(lhs.originWord == rhs.originWord);
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

       public override string ToString()
        {
            string buff = originWord + " ";
            foreach (string str in translate)
                buff += str + " ";
            return buff;
        }
    }
}
