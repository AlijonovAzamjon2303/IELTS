using System.Security.Cryptography;

Console.Write("Listening score : ");
string listeningInput = Console.ReadLine();

Console.Write("Reading score : ");
string readingInput = Console.ReadLine();

Console.Write("Writing score : ");
string writingInput = Console.ReadLine();

Console.Write("Speaking score : ");
string speakingInput = Console.ReadLine();

decimal [] scores = 
{
    Convert.ToDecimal(listeningInput),
    Convert.ToDecimal(readingInput),
    Convert.ToDecimal(writingInput),
    Convert.ToDecimal(speakingInput)
};

decimal avaregeScore = scores.Average();
int intAverageScore = (int)avaregeScore;
decimal remainder = avaregeScore - intAverageScore;

remainder = remainder switch
{
    _ when remainder < 0.25m => 0,
    _ when remainder < 0.75m => 0.5m ,
    _ => 1
};

decimal bandScore = intAverageScore + remainder;

Console.WriteLine($"Sizning natijangiz : {bandScore}");

string level;
if(bandScore == 9)
{
    level = "Expert";
}
else if(bandScore >= 8)
{
    level = "Very Good";
}
else if(bandScore >= 7)
{
    level = "Good";
}
else if(bandScore >= 6)
{
    level = "Competent";
}
else 
{
    level = "Modest";
}
Console.WriteLine("Your level : " + level);