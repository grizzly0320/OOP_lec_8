using static System.Console;
using OOP_lec_8;

Collection c = new Collection(Collection.Type.Even);
foreach (var x in c)
{
    Write($"{(int)x} ");
}
WriteLine();

YCollection co = new YCollection(YCollection.Type.Odd);
foreach (var x in co)
{
    Write($"{(int)x} ");
}


//int[] a = new int[] { 1, 3, 5, 7, 9 };
//foreach(int elem in a)
//{
//    Write($"{elem} ");
//}
//WriteLine();
//int[,] m = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
//int sum = 0;
//foreach(int elem in m)
//{
//    //elem *= 10 // Ошибка!
//    Write($"{elem} ");
//    sum += elem;
//}
//WriteLine();
//WriteLine(sum);
//List<int> lst = new List<int>();
//// Изменение коллекции во время работы цикла foreach невозможно, если только используется не ссылочные типы данных
//foreach(int elem in lst)
//{
//    Write($"{elem}");
//    //lst.Add(elem) // Ошибка!
// }
//List<A> lst2 = new List<A>();
//foreach(var elem in lst2)
//{
//    elem.Value *= 10;
//    Write($"{elem}");
//}
//class A
//{
//    public int Value { get; set; } 
//}