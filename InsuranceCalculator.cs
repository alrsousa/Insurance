internal class insuree { 
{
public static int Quote { get; private set; }

    private static void Main(string[] args)
    {
        insuree.Quote = 500;

        int age = DateTime.Now.Year - insuree.DateOfBirth.Year;



        if (age <= 18)
        {
            insuree.Quote = insuree.Quote + 100; //Adding 100 because 18 or minus aged
        }

        if (age >= 19 && age <= 25)
        {
            insuree.Quote = insuree.Quote + 50; //Adding 50 because aged between 19 and 25
        }

        if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
        {
            insuree.Quote = insuree.Quote + 25; //Adding 25 if the car is very old or very new
        }

        if (insuree.CarMake == "Porsche" || insuree.CarMake == "porsche")
        {
            insuree.Quote = insuree.Quote + 25;  //Adding 25 for being porsche
        }

        if (insuree.CarMake == "Porsche" || insuree.CarMake == "porsche" && insuree.CarModel == "911 Carrera")
        {
            insuree.Quote = insuree.Quote + 25;  //Adding more 25 for Carrera model
        }

        if (insuree.SpeedingTickets > 0)
        {
            insuree.Quote = insuree.Quote + insuree.SpeedingTickets * 10; //Adding 10 for speeding tickets
        }

        if (insuree.DUI == true)
        {
            insuree.Quote = insuree.Quote + insuree.Quote * 0.25;
        }

        if (insuree.CoverageType == true)
        {
            insuree.Quote = insuree.Quote + insuree.Quote * 0.25;
        }
    }
}

}


