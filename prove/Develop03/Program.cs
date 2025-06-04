using System;

class Program
{

    /*Strech challenge
    1. It loads from a JSON file which contains a library of scriptures.
    2. It randomly picks a scripture.
    3. It randomly hides words that are not already hidden.
    4. It accepts any text case of the "quit" word using ".ToLower()" method.
    */



    static void Main(string[] args)
    {
        List<Passage> passages = Json.LoadFromJson("lds-scriptures.json");
        if (passages.Count == 0)
        {
            return;
        }

        Random random = new Random();
        int index = random.Next(passages.Count);
        Passage passage = passages[index];

        Scripture scripture = new Scripture(passage);

        while (true)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress ENTER to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            if (!scripture.HideWord())
            {
                Console.WriteLine("All words are hidden.");
                break;
            }
        }
    }
            

}
