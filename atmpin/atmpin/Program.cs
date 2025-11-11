class AssignmentPINValidation
{
    static void Main()
    {
        DebitCard debitCard = new DebitCard();
        debitCard.PIN = "1234"; //Output: PIN contains one or more non-digit characters.
        System.Console.WriteLine(debitCard.PIN); //Output: null (shown as blank)
        System.Console.ReadKey();
    }
}