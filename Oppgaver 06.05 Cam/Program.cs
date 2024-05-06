using Oppgaver_06._05_Cam;

int integer = 1;
string String = "word";
double doubleNumber = 2.5;

string[] names = { "Anna", "Ole", "Kari", "Jens" };

List<string> list = new List<string>() { "Hello", "this", "is", "C#"};
//Console.WriteLine(names);
//Console.WriteLine(list);

for (int i = 0;i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

Person person = new Person();
person.Name = "Camilla";
Console.WriteLine(person.Name);

Console.WriteLine(AddNumbers(1, 3));
Console.WriteLine(AddNumbers((int)1.5, 3));
static int AddNumbers(int a, int b)
{
    return a + b;
}

string phrase = "The quick brown fox";
string[] words = phrase.Split(' ');

foreach (var word in words)
{
    Console.WriteLine(word);
}

