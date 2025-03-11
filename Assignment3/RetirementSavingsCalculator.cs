namespace Assignment3;

public class RetirementSavingsCalculator
{
    private decimal initialInvestment;
    private decimal monthlyContribution;
    private decimal annualInterestRate;
    private int numberOfPayments;
    private decimal monthlyFees;

    public RetirementSavingsCalculator(decimal initialInvestment, decimal monthlyContribution, decimal annualInterestRate, int numberOfPayments, decimal monthlyFees = 0)
    {
        this.initialInvestment = initialInvestment;
        this.monthlyContribution = monthlyContribution;
        this.annualInterestRate = annualInterestRate;
        this.numberOfPayments = numberOfPayments;
        this.monthlyFees = monthlyFees;
    }

    public decimal CalculateFutureValue(out decimal totalInterest, out decimal totalFees)
    {
        decimal balance = initialInvestment + monthlyContribution;
        decimal monthlyInterestRate = (annualInterestRate / 100) / 12;
        decimal monthlyFeeRate = (monthlyFees / 100) / 12;
        totalInterest = 0;
        totalFees = 0;

        for (int month = 1; month <= numberOfPayments; month++)
        {
            decimal interest = monthlyInterestRate * balance;
            decimal fees = monthlyFeeRate * balance;
            balance += interest - fees + monthlyContribution;
            totalInterest += interest;
            totalFees += fees;
        }

        return balance;
    }
}
