// See https://aka.ms/new-console-template for more information

CalculatorApp();

void CalculatorApp()
{
    int firstnumber = 0;
    int secondnumber = 0;
    int result = 0;
    char calctype = 'A';

    Console.WriteLine("Type in the first number followed by the enter key");
    firstnumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Type in the second number followed by the enter key");
    secondnumber = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Choose an item from the following list:\n1-Add\n2-Subtract\n3-Divide\n4-Multiply");
    calctype = Convert.ToChar(Console.ReadLine());

    switch (calctype)
    {
        case '1':
            result = firstnumber + secondnumber;
            break;
        case '2':
            result = firstnumber - secondnumber;
            break;
        case '3':
            result = firstnumber / secondnumber;
            break;
        case '4':
            result = firstnumber * secondnumber;
            break;

    }    


    
    ;
    Console.WriteLine($"The result is {result}");
    Console.ReadKey();

    Console.WriteLine("Please Work");

}


