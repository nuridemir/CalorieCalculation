

Console.Write("Lütfen kilonuzu giriniz: ");
int kg = int.Parse(Console.ReadLine());


KiloKoruma(kg);
KiloAlma(kg);
KiloVerme(kg);


static void KiloKoruma(int kg)
{

    int kalori = kg * 33;
    
    int protein = kg * 2;
    int proteinKalori = protein * 4;

    double yagKalori = kalori * 0.3;
    double yag = yagKalori / 9;

    double karbonhidratKalori = kalori - (proteinKalori + yagKalori);
    double karbonhidrat = karbonhidratKalori / 4;

    Console.WriteLine();
    Console.WriteLine(kg + " kilo için günlük kg koruma bilgileriniz");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Günlük kalori miktarınız: " + kalori);
    Console.WriteLine("Günlük protein miktarınız: " + protein);
    Console.WriteLine("Günlük yag miktarınız: " + yag);
    Console.WriteLine("Günlük karb miktarınız: " + karbonhidrat);

}

static void KiloAlma(int kg)
{
    int acik = 400;
    int kalori = kg * 33 + acik;

    int protein = kg * 2;
    int proteinKalori = protein * 4;

    double yagKalori = kalori * 0.3;
    double yag = yagKalori / 9;

    double karbonhidratKalori = kalori - (proteinKalori + yagKalori);
    double karbonhidrat = karbonhidratKalori / 4;

    Console.WriteLine();
    Console.WriteLine(kg + " kilo için günlük kilo alma bilgileriniz");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Günlük kalori miktarınız: " + kalori);
    Console.WriteLine("Günlük protein miktarınız: " + protein);
    Console.WriteLine("Günlük yag miktarınız: " + yag);
    Console.WriteLine("Günlük karb miktarınız: " + karbonhidrat);

}


static void KiloVerme(int kg)
{

    int acik = 400;
    int kalori = kg * 33 - acik;

    int protein = kg * 2;
    int proteinKalori = protein * 4;

    double yagKalori = kalori * 0.3;
    double yag = yagKalori / 9;

    double karbonhidratKalori = kalori - (proteinKalori + yagKalori);
    double karbonhidrat = karbonhidratKalori / 4;

    Console.WriteLine();
    Console.WriteLine(kg + " kilo için günlük kilo verme bilgileriniz");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Günlük kalori miktarınız: " + kalori);
    Console.WriteLine("Günlük protein miktarınız: " + protein);
    Console.WriteLine("Günlük yag miktarınız: " + yag);
    Console.WriteLine("Günlük karb miktarınız: " + karbonhidrat);

}

