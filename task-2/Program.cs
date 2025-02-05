// Задача 2: Замена заглавных букв на строчные в строке

string GetSmall (string str1){

    return str1.ToLower();  // Просто приводим всю строку к нижнему регистру
}

string str2 = Console.ReadLine();
string strDone = GetSmall(str2);
Console.WriteLine(strDone); 

