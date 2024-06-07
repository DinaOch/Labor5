using Лаба5;

try
{
    // Запросить имя файла и строку для записи
    Console.Write("Введите имя файла: ");
    string fileName = Console.ReadLine();
    Console.Write("Введите строку для записи: ");
    string inputString = Console.ReadLine();

    // Проверить, что строка содержит как минимум 3 символа
    if (inputString.Length < 3)
    {
        throw new StringTooShortException("Строка слишком мала.");
    }

    // Записать третий символ строки в файл
    using (StreamWriter writer = new StreamWriter(fileName))
    {
        writer.Write(inputString[2]);
    }

    Console.WriteLine("Данные успешно записаны в файл.");
}
catch (StringTooShortException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine($"Произошло исключение: {ex.Message}");
}
finally
{
    Console.WriteLine("Выполнение программы завершено.");
}