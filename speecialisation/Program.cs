//Оставляем в массиве элементы менее 3 символов
string [] arr = {"hello","2","world",":-)"};
string [] arrRes = {};

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        Array.Resize(ref arrRes, arrRes.Length+1);
        arrRes[arrRes.Length-1] = arr[i];
    }
}

for (int j = 0; j < arrRes.Length; j++)
{
    Console.WriteLine(arrRes[j]);
}