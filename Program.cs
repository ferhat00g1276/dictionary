using System.Xml.Linq;

class Program
{
    class Word
    {
        public Word(string wordTextAze, string wordTextEng)
        {
            this.wordTextAze = wordTextAze;
            this.wordTextEng = wordTextEng;
        }

        public string wordTextAze { get; set; }
        public string wordTextEng { get; set; }
        public override string ToString()
        {
            return "Word in Azerbaijani: " + wordTextAze + "\n" + "Word in English: " + wordTextEng;
        }
    }
    class Dictionary
    {
        List<Word> words = new List<Word>();

        public Dictionary(string dictionaryName, List<Word> wordsArg)
        {
            DictionaryName = dictionaryName;
            words = wordsArg;
        }

        public string DictionaryName { get; set; }
        public Word this[int index]
        {
            get
            {
                if (index >= 0 || index < words.Count)
                {
                    return words[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                words[index] = value;
            }
        }
    }
    static void Main(string[] args)
    {
        Word word1 = new Word("salam", "hello");
        Word word2 = new Word("sagol", "goodbye");
        List<Word> words = new List<Word>();
        words.Add(word1);
        words.Add(word2);
        Dictionary dic1 = new Dictionary("dic1", words);
        Console.WriteLine(dic1[0]);
        Console.WriteLine(dic1[1]);

    }
}