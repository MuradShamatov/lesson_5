// Задача 3: Проверка строки на палиндром

bool IsPalindrom (string str)
{
    str = str.ToLower().Replace(" ", "");  // Приводим к нижнему регистру и убираем пробелы
    int left = 0;
    int right = str.Length - 1;
    while(left<right)
    {
     if(str[left] != str[right])
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
}


Console.Write("Vvedite: ");
string palindrom = Console.ReadLine();

if(IsPalindrom(palindrom))
{
    Console.WriteLine("Da palindrom");
}

else Console.WriteLine("No");