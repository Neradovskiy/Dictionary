using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace task8
{
    [Serializable]
    class Dictionary
    {
        public Dictionary(string name)
        {
            _words = new List<Word>();
            Name = "dictionary";
        }

        public Dictionary(List<Word> dictionary)
        {
            _words = dictionary;
            Name = "dictionary";
        }

        public bool Add(Word word)
        {
            bool added = false;
            bool origin = true;
            foreach (Word i in _words)
                if (i.originWord == word.originWord)
                {
                    origin = false;
                    added = AddTranslate(word.originWord, word.translate);
                }
            if (origin)
            {
                _words.Add(word);
                added = true;
            }
            return added;
        }

        public bool Contains(Word word)
        {
            return _words.Contains(word);
        }

        public bool Contains(string word)
        {
            foreach (Word i in _words)
                if (i.originWord == word)
                    return true;
            return false;
        }

        public List<string> Translate(string word)
        {

            for (int i = 0; i < _words.Count; ++i)
            {
                if (_words[i].originWord == word)
                    return new List<string>(_words[i].translate);
            }
            return null;
        }

        public bool AddTranslate(string word, string transl)
        {
            foreach (Word i in _words)
            {
                if (i.originWord == word && !(i.translate.Contains(transl)))
                {
                    i.translate.Add(transl);
                }
                return true;
            }
            return false;
        }

        public bool AddTranslate(string word, List<string> transl)
        {
            bool added = false;
            foreach (Word i in _words)
                if (i.originWord == word)
                    foreach (string str in transl)
                        if (!i.translate.Contains(str))
                        {
                            i.translate.Add(str);
                            added = true;
                        }
            return added;
        }

        public void Remove(string word)
        {
            for (int i = 0; i < _words.Count; ++i)
            {
                if (word == _words[i].originWord)
                    _words.RemoveAt(i);
                return;
            }
        }
        public void Save()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            try
            {
                using (Stream fstream = new FileStream(Name, FileMode.Append, FileAccess.Write))
                    binFormatter.Serialize(fstream, _words);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Load(string name)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            try
            {
                using (Stream fstream = new FileStream(Name, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    _words = (List<Word>)binFormatter.Deserialize(fstream);
                    Name = name;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        List<Word> _words;
        string Name { get; set; }
    }
}
