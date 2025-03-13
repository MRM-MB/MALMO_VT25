namespace Assignment3;

/// <summary>
/// Calculates retirement savings based on monthly contributions and compound interest.
/// Algorithm:
/// 1. Initial balance = initial deposit + monthly saving
/// 2. For each month:
///    - Calculate interest: monthly interest rate × balance
///    - Calculate fees: monthly fee rate × balance
///    - Update balance: add interest, subtract fees, add monthly contribution
///    - Track total interest and fees
/// </summary>
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
        decimal monthlyInterestRate = annualInterestRate / 100 / 12;
        decimal monthlyFeeRate = monthlyFees / 100 / 12;
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

    /// <summary>
    /// Calculates the growth rate as a percentage of total interest relative to final balance
    /// </summary>
    /// <returns>Growth rate as a percentage</returns>
    public decimal CalculateGrowthRate()
    {
        decimal totalInterest, totalFees;
        decimal finalBalance = CalculateFutureValue(out totalInterest, out totalFees);
        return (totalInterest / finalBalance) * 100;
    }

    /// <summary>
    /// Calculates the total amount paid in contributions
    /// </summary>
    /// <returns>Sum of initial investment and all monthly contributions</returns>
    public decimal CalculateTotalAmountPaid()
    {
        return initialInvestment + (numberOfPayments * monthlyContribution);
    }
}
