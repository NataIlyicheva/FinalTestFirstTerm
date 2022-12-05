Console.Write("Введите несколько элементов через пробел ");
string str = new string (Console.ReadLine());
string[] array = str.Split(new char[] {' '});
for (int i = 0; i < array.Length; i++)
{
   int input = Convert.ToInt32(array[i].Length);
   if (input <= 3)
   {
      Console.WriteLine(array[i]);
      count++;
   }
}
