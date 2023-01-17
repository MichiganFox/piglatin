bool newgame = true;

while (newgame)
{
  
    // The application prompts the user for a word.
    Console.WriteLine("Welcome to the Pig Latin game.  Please enter a word: ");
    // Convert each word to a lowercase before translating.
    string word = Console.ReadLine().ToLower().Trim();
    int VowelLocation = -1;
    foreach (char letter in word)
    {
        VowelLocation = VowelLocation + 1;
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            break;
        }
    }


    string PigLatin = "";
    string beforeLetters = "";
    string afterLetters = "";
    //If a word starts with a vowel, just add “way” onto the ending.
    switch (VowelLocation)
    {
        case 0:
            PigLatin = word + "way";
            break;
        //if a word starts with a consonant, move all of the consonants that appear before the first vowel to the end of the word, then add “ay” to the end of the word. 
        case 1:
            beforeLetters = word.Substring(0, 1);
            afterLetters = word.Substring(1);
            PigLatin = afterLetters + beforeLetters + "ay";
            break;

        case 2:
            beforeLetters = word.Substring(0, 2);
            afterLetters = word.Substring(2);
            PigLatin = afterLetters + beforeLetters + "ay";
            break;

        case 3:
            beforeLetters = word.Substring(0, 2);
            afterLetters = word.Substring(2);
            PigLatin = afterLetters + beforeLetters + "ay";
            break;

        case 4:
            beforeLetters = word.Substring(0, 3);
            afterLetters = word.Substring(3);
            PigLatin = afterLetters + beforeLetters + "ay";
            break;

        case 5:
            beforeLetters = word.Substring(0, 4);
            afterLetters = word.Substring(4);
            PigLatin = afterLetters + beforeLetters + "ay";
            break;

        case 6:
            beforeLetters = word.Substring(0, 5);
            afterLetters = word.Substring(5);
            PigLatin = afterLetters + beforeLetters + "ay";
            break;
        case 7:
            beforeLetters = word.Substring(0, 6);
            afterLetters = word.Substring(6);
            PigLatin = afterLetters + beforeLetters + "ay";
            break;

        case 8:
            beforeLetters = word.Substring(0, 7);
            afterLetters = word.Substring(7);
            PigLatin = afterLetters + beforeLetters + "ay";
            break;
        case 9:
            beforeLetters = word.Substring(0, 8);
            afterLetters = word.Substring(8);
            PigLatin = afterLetters + beforeLetters + "ay";
            break;
    }
    //The application translates the text to Pig Latin and displays it on the console.
    Console.WriteLine(("Transaltion -- " + PigLatin));
    Console.WriteLine();
    // The application asks the user if he or she wants to translate another word.
    Console.WriteLine("Would you like to play again?  y/n?");

    string user_answer = Console.ReadLine();

    if (user_answer == "no" || user_answer == "n")
    {
        newgame = false;
    }
    else
    {
        newgame = true; 
    }
}
   



