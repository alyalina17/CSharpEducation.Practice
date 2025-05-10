string[] word = new string[3];
int i = 0;
do
{
    word[i] = Console.ReadLine();
    i++;
}

while (i < 3);

for (int k = 0; k < word.Length; k++)
{

    Console.Write(word[k] + " ");
}

