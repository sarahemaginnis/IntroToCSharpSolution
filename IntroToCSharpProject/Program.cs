//pick a number between 1 and 100

//type variable name           Classes need to be instantiated with the 'new' keyword
Random randomNumberGenerator = new Random();
int numberToGuess = randomNumberGenerator.Next(1, 101);

Console.Write("Pick a number between 1 and 100: ");
string input = Console.ReadLine();
int inputAsInt = int.Parse(input);

bool correctGuess = false;
if (numberToGuess == inputAsInt) 
{ 
    correctGuess = true; 
}

//ternary; different way of writing an if statement
//ternary: if statement comes first, then true then false
string responseText = correctGuess 
    ? $"That's right, the number I was thinking of was {numberToGuess}!" 
    : $"Wow, you're bad at this. I was thinking of {numberToGuess} but you guessed {input}.";

//string correctResponse = $"That's right, the number I was thinking of was {numberToGuess}!";
//string incorrectResponse = $"Wow, you're bad at this. I was thinking of {numberToGuess} but you guessed {input}.";

Console.WriteLine(responseText);

//if (correctGuess)
//{
//    Console.WriteLine(correctResponse);
//}
//else
//{
//    Console.WriteLine(incorrectResponse);
//}

Console.ReadLine();
