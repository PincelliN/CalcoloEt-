Console.WriteLine("Inserisci la tua data di nascita");
string dateOfBirth = Console.ReadLine();

static int getAnni(DateTime dataDiNascità, DateTime today)
{
    return today.Month > dataDiNascità.Month ? today.Year - dataDiNascità.Year : (today.Year - dataDiNascità.Year) - 1;
}

bool input = DateTime.TryParse(dateOfBirth, out DateTime dataDiNascità);
DateTime today = DateTime.Today;
Console.WriteLine(today);
if (input)
{
    int age = getAnni(dataDiNascità, today);
    Console.WriteLine(age);
}