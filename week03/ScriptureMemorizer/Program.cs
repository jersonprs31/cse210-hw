/*Instead of using a single scripture, I created a library (List) of scriptures.
The program randomly selects one scripture from this library to present to the user each time the program runs.*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>();
        scriptureLibrary.Add(new Scripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        scriptureLibrary.Add(new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."));
        scriptureLibrary.Add(new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."));
        scriptureLibrary.Add(new Scripture(new Reference("Doctrine and Covenants", 6, 36), "Look unto me in every thought; doubt not, fear not."));
        scriptureLibrary.Add(new Scripture(new Reference("Moroni", 10, 4, 5), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."));
        
        Random random = new Random();
        int index = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[index];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (selectedScripture.IsCompletelyHidden())
            {
                break;
            }

            selectedScripture.HideRandomWords(3);
        }
    }
}