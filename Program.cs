Console.Write("Введите несколько элементов через пробел ");
string str = new string (Console.ReadLine());
string[] array = str.Split(new char[] {' '});
int count = 0;

for (int i = 0; i < array.Length; i++)
{
   int input = Convert.ToInt32(array[i].Length);
   if (input <= 3)
   {
      Console.WriteLine(array[i]);
      count++;
   }
}
    if (count == 0) 
    Console.WriteLine("Введенные элементы содержат > 3 символов");
