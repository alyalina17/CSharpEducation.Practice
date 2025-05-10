string[] word = new string[3];
int i = 0;
while (true) 

{
    word[i] = Console.ReadLine();
    i++;
    if (i == 3)
        break;
}
for (int k = 0; k < word.Length; k++) 
{
   
    Console.Write(word[k] + " ");
}

