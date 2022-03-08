// See https://aka.ms/new-console-template for more information

TaxesByMonth.TaxesByMonth taxesByMonth = new TaxesByMonth.TaxesByMonth();
var taxes = taxesByMonth.CalculateTaxesByMonth();

foreach (TaxesByMonth.TaxesByMonth.TaxesByMonthL i in taxes)
{
    string month = "";
    switch (i.NumberMonth)
    {
        case (1):
            month = "January";
            break;
        case (2):
            month = "February";
            break;
        case (3):
            month = "March";
            break;
        case (4):
            month = "April";
            break;
        case (5):
            month = "May";
            break;
        case (6):
            month = "June";
            break;
        case (7):
            month = "July";
            break;
        case (8):
            month = "August";
            break;
        case (9):
            month = "Sepember";
            break;
        case (10):
            month = "October";
            break;
        case (11):
            month = "November";
            break;
        case (12):
            month = "December";
            break;
    }
    Console.WriteLine(month + " Taxes = $" + i.Taxes);
}

Console.ReadLine();