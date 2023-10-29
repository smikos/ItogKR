int Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


string [] InputArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
      System.Console.WriteLine("Введите строку");
       array[i]=Console.ReadLine();

    }
    return array;
}


void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
  
  System.Console.Write( $"{array[i]}  ");  
}
}
int length =Prompt ("Введитеколичество элементов > ");
string [] array;

array = InputArray(length);

PrintArray(array);
