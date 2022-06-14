using Lab4;

while (true)
{
    int v, w;
    Vantazhoperevisnyk vantazhoperevisnyk;
    do
    {
        Console.WriteLine("Виберіть вид транспорту для перевезення вантажу: \n1) Автомобіль. \n2) Літак \n3) Поїзд");
        v = Convert.ToInt32(Console.ReadLine());
    } while (v < 0 && v >= 3);
    
    do
    {
        Console.WriteLine("Введіть масу вантажу для перевезення(в тонах): ");
       string st = Console.ReadLine();
        if (int.TryParse(st, out w))
        {
            break;
        }
    } while (true);

    if (v == 1) vantazhoperevisnyk = new Car(w);
    else if (v == 2) vantazhoperevisnyk = new Plane(w);
    else if (v == 3) vantazhoperevisnyk = new Train(w);
    else  vantazhoperevisnyk = new Train(0); 
    
    vantazhoperevisnyk.ShowCities();
    
    bool corectNum = true;
    do
    {
        Console.WriteLine("Введіть номер, під яким потрібне Вам сполучення міст: ");
        string st = Console.ReadLine();
        if (int.TryParse(st, out w))
        {
            vantazhoperevisnyk.Choose_Distance(w, ref corectNum);
        }
    } while (corectNum);
    
    Console.WriteLine(vantazhoperevisnyk.PriceForFuel() + " grn");
    Console.WriteLine(vantazhoperevisnyk.Time_of_transportation() + " god");
   
    Console.ReadKey();
}
Console.ReadKey();