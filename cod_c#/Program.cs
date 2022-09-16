// метод вобора элементов маасива
void Array3Simb (string [] ArrayFerst)
{
    string [] ArrayResult = new string [ArrayFerst.GetLength (0)];
    Console.Write ("[");
    int Count = 0;
    for (int i = 0; i < ArrayFerst.GetLength (0); i ++)
        {
            if (ArrayFerst[i].Length <= 3)
                {
                     ArrayResult [Count] = ArrayFerst [i];
                     Console.Write ($"{ArrayResult [Count]} ");
                     Count++;
                }
        }
    Console.WriteLine ("]");
}
string[] Array = new string[] {"Привет", "Как", "Дела", "?", "Все" , "Хорошо", "?", "А"};
Array3Simb (Array);

 