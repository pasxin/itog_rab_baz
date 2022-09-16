// метод вобора элементов маасива
void SizeArray3 (string [] ArrayFerst)
{
    string [] ArrayResult = new string [ArrayFerst.GetLength (0)];
    Console.Write ("[");
    int count = 0;
    for (int i = 0; i < ArrayFerst.GetLength (0); i ++)
        {
            if (ArrayFerst[i].Length <= 3)
                {
                     ArrayResult [count] = ArrayFerst [i];
                     Console.Write ($"{ArrayResult [count]} ");
                     count++;
                }
        }
    Console.WriteLine ("]");
}
string[] Array = new string[] {"Привет", "Как", "Дела", "?", "Все" , "Хорошо", "?", "А"};
SizeArray3 (Array);

 