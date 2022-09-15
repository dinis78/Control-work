Console.Clear();

string[] arr;
Console.WriteLine("Введите в массив строки, значения через запятую");
string stroka = Console.ReadLine();
arr = stroka.Split(',');

string [] arr1= new string[arr.Length];
void NewArray(string[]arr,string[]arr1)
{

int count=0;
for (int i=0; i<arr.Length; i++)
 {
   if (arr[i].Length<=3)
   {
    arr1[count]=arr[i];
    count++;
   }
 }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Write("=> ");
NewArray(arr, arr1);
PrintArray(arr1 );

