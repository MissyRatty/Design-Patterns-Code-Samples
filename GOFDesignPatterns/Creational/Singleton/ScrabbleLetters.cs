using System.Collections.Generic;
using System.Linq;

namespace GOFDesignPatterns.Creational.Singleton
{
    public class ScrabbleLetters
    {
        //holds the one and only instance of this class.
        private static ScrabbleLetters _instance = null;

        //lock object
        private static readonly object _lock = new object();

        //hold all 6 scrabble letters
        readonly List<string> gameLetters = new List<string> { "a", "b", "c", "d", "e", "f" };

        //private so that a new instance of this class cannot be created outside of this class.
        private ScrabbleLetters()
        {
        }

        //global point of access to this class's instance
        public static ScrabbleLetters Instance()
        {
            //create a new instance if only one doesn't exist already
            //This is also known as lazy instantiation / initialization
            //i.e: if the instance is not needed, it will never be created.
            // this instance is only created when this GetInstance method is called
            // To make this thread safe, i.e: Supporting Multithreading
            //It will use the Double Checked Locking which, once the instance exists, 
            // will avoid locking each time the method is invoked

            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ScrabbleLetters();
                }
            }

            return _instance;
        }

        public IEnumerable<string> GetAvailableGameLetters()
        {
            return gameLetters;
        }

        public IEnumerable<string> GetTiles(int numberOfTiles)
        {
            List<string> tilesToSend = new List<string>();

            if (numberOfTiles <= gameLetters.Count)
            {
                tilesToSend.AddRange(gameLetters.Take(numberOfTiles));
                RefreshTiles(tilesToSend);
            }

            return tilesToSend;
        }

        private void RefreshTiles(List<string> lettersToRemove)
        {
            gameLetters.RemoveAll(lettersToRemove.Contains);
        }
    }
}
