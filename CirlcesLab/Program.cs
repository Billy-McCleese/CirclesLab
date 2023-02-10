using CirclesLab;

Console.WriteLine("Welcome to the Circle Tester");
//possible do while loop or for each loop to loop through if the user goes again 
//also need something to keep track of how many attempts made
bool Close = false;
double CircleUserInput;
int NumberOfCircles = 0;
while (!Close)
{

    do
    {
        Console.WriteLine("Enter radius: ");
        try
        {
            CircleUserInput = double.Parse(Console.ReadLine());
            NumberOfCircles++;
            break;
        }
        catch (Exception)
        {

            Console.WriteLine("That is not a valid entry.");
            Close = false;
        }
    } while (true);
 
            Circle CircleInput = new Circle();
            CircleInput.Radius = CircleUserInput;

            Double CircumferenceNotRounded = CalculateCircumferenceLab.CalculateCircumference(CircleUserInput);
            Double CircumferenceRounded = CalculateCircumferenceLab.CircumferenceFormatted(CircumferenceNotRounded);
            Console.WriteLine("Circumference: " + CircumferenceRounded);

            Double AreaNotRounded = CalculateAreaeLab.CalculateArea(CircleUserInput);
            Double AreaRounded = CalculateAreaeLab.CalculateFormattedArea(AreaNotRounded);
            Console.WriteLine("Area: " + AreaRounded);

            Console.WriteLine("Would you like to do this again (y/n)");
            string UserContinue = (Console.ReadLine().ToLower());
            if (UserContinue is "y")
            {
                Close = false;
            }
            else
            {
                Close = true;
                Console.WriteLine("See Ya! You created " + NumberOfCircles + " Circle object(s)");
            }

}
