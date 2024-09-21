#region bài 1
// Console.Write("Enter the number of days: ");
// int numberOfDays = Convert.ToInt32(Console.ReadLine());

// int numberOfWeeks = numberOfDays / 7;
// int remainingDays = numberOfDays % 7;

// Console.WriteLine($"{numberOfDays} days are equal to {numberOfWeeks} week and {remainingDays} day.");
#endregion

#region bài 2
// Console.Write("Enter the order value: ");
// decimal orderValue = Convert.ToDecimal(Console.ReadLine());

// Console.Write("Enter the discount percentage: ");
// decimal discountPercentage = Convert.ToDecimal(Console.ReadLine());

// decimal discountAmount = orderValue * discountPercentage / 100;

// decimal totalAmountToPay = orderValue - discountAmount;

// Console.WriteLine($"Discount amount: {discountAmount} VND");
// Console.WriteLine($"Total amount to pay after discount: {totalAmountToPay} VND");
#endregion


#region bài 3
// Console.Write("Enter the number of minutes: ");
// int totalMinutes = Convert.ToInt32(Console.ReadLine());

// int hours = totalMinutes / 60;
// int minutes = totalMinutes % 60;

// Console.WriteLine($"{totalMinutes} minutes is equivalent to {hours} hours and {minutes} minutes.");
#endregion

#region bài 4
// Console.Write("Enter the base amount: ");
// decimal baseAmount = Convert.ToDecimal(Console.ReadLine());

// Console.Write("Enter the VAT rate (%): ");
// decimal vatRate = Convert.ToDecimal(Console.ReadLine());

// decimal vatAmount = (baseAmount * vatRate) / 100;

// decimal totalAmount = baseAmount + vatAmount;

// Console.WriteLine($"Total amount after adding VAT is: {totalAmount} (VAT amount is: {vatAmount})");
#endregion

#region bài 5
// Console.Write("Enter the amount (USD): ");
// decimal usdAmount = Convert.ToDecimal(Console.ReadLine());

// Console.Write("Enter the exchange rate (1 USD = VND): ");
// decimal exchangeRate = Convert.ToDecimal(Console.ReadLine());

// decimal vndAmount = usdAmount * exchangeRate;

// Console.WriteLine($"{usdAmount} USD is equivalent to {vndAmount} VND.");
#endregion



class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select a task to run:");
            Console.WriteLine("1. Convert days to weeks and days");
            Console.WriteLine("2. Calculate discount on order value");
            Console.WriteLine("3. Convert minutes to hours and minutes");
            Console.WriteLine("4. Calculate total amount after VAT");
            Console.WriteLine("5. Convert USD to VND");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Bài 1
                    Console.Write("Enter the number of days: ");
                    int numberOfDays = Convert.ToInt32(Console.ReadLine());
                    int numberOfWeeks = numberOfDays / 7;
                    int remainingDays = numberOfDays % 7;
                    Console.WriteLine($"{numberOfDays} days are equal to {numberOfWeeks} week(s) and {remainingDays} day(s).");
                    break;

                case 2:
                    // Bài 2
                    Console.Write("Enter the order value: ");
                    decimal orderValue = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter the discount percentage: ");
                    decimal discountPercentage = Convert.ToDecimal(Console.ReadLine());
                    decimal discountAmount = orderValue * discountPercentage / 100;
                    decimal totalAmountToPay = orderValue - discountAmount;
                    Console.WriteLine($"Discount amount: {discountAmount} VND");
                    Console.WriteLine($"Total amount to pay after discount: {totalAmountToPay} VND");
                    break;

                case 3:
                    // Bài 3
                    Console.Write("Enter the number of minutes: ");
                    int totalMinutes = Convert.ToInt32(Console.ReadLine());
                    int hours = totalMinutes / 60;
                    int minutes = totalMinutes % 60;
                    Console.WriteLine($"{totalMinutes} minutes is equivalent to {hours} hours and {minutes} minutes.");
                    break;

                case 4:
                    // Bài 4
                    Console.Write("Enter the base amount: ");
                    decimal baseAmount = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter the VAT rate (%): ");
                    decimal vatRate = Convert.ToDecimal(Console.ReadLine());
                    decimal vatAmount = (baseAmount * vatRate) / 100;
                    decimal totalAmount = baseAmount + vatAmount;
                    Console.WriteLine($"Total amount after adding VAT is: {totalAmount} (VAT amount is: {vatAmount})");
                    break;

                case 5:
                    // Bài 5
                    Console.Write("Enter the amount (USD): ");
                    decimal usdAmount = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter the exchange rate (1 USD = VND): ");
                    decimal exchangeRate = Convert.ToDecimal(Console.ReadLine());
                    decimal vndAmount = usdAmount * exchangeRate;
                    Console.WriteLine($"{usdAmount} USD is equivalent to {vndAmount} VND.");
                    break;

                case 0:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}

