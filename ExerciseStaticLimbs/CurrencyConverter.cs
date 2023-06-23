namespace ExerciseStaticLimbs
{
    public class CurrencyConverter
    {
        
        public static double Iof = 0.06;

        public static double CalculateTotalPaidReal(double dollarExchangeRate, double dollarAmount)
        {
            return dollarExchangeRate * dollarAmount + CalculateTax(dollarExchangeRate, dollarAmount);
        }

        public static double CalculateTax(double dollarExchangeRate, double dollarAmount)
        {
            return dollarExchangeRate * dollarAmount * Iof;
        }
    }
}