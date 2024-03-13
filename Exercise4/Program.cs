List<string> words = [];

Console.WriteLine("Quantas palavras deseja inserir?");

var wordsQuantity = Console.ReadLine();
var quantity = int.Parse(wordsQuantity);

for (var round = 0; round < quantity; round++)
{
    var current = round + 1;
    
    Console.WriteLine($"Digite a palavra {current}:");

    var word = Console.ReadLine();

    if (string.IsNullOrEmpty(word))
    {
        return;
    }
    
    words.Add(word.Trim().Replace(" ", ""));
}

words.ForEach(word =>
{
    Console.WriteLine($"A palavra {word} tem {word.Length} caracteres.");
});
