String[] mas0 = new String[10];
mas0[0] = "1111";
mas0[1] = "22222";
mas0[2] = "33333";
mas0[3] = "3";
mas0[4] = "444444";
mas0[5] = "5555555";
mas0[6] = "23";
mas0[7] = "77777777";
mas0[8] = "888888888";
mas0[9] = "123";
int len = 0;
foreach (String s in mas0)
{
    if (s.Length<=3)
    {
        len = len + 1;

    }
}
String[] mas1 = new String[len];
int i = 0;
foreach (String s in mas0)
{
    if (s.Length<=3)
    {
        mas1[i] = s;
        i = i + 1; 
    }
}
f5(mas0);
f5(mas1);
/*
Выводит массив на экран
*/
void f5 (String[] mas)
{
    Console.Write("[ ");
    foreach(var n in mas)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine("]");
}
