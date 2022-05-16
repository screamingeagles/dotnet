using System;
public abstract class BillingBase
{
    public const float MINIMUM_PER_HOUR_RATE = 7.25F;       // Federally mandated US minimium per hour wage
    protected int getWorkingDays()
    {
        Random rand = new Random();
        return rand.Next(28, 31);
    }
    public abstract float CalculatePayableAmount(int WorkingDays);
}
public class PermanentEmployeeWage : BillingBase
{
    public new int getWorkingDays()
    {
        return base.getWorkingDays();
    }
    public override float CalculatePayableAmount(int WorkingDays)
    {
        return WorkingDays * (MINIMUM_PER_HOUR_RATE + 50);
    }
}
public class TemporaryEmployeeWage : BillingBase
{
    public new int getWorkingDays()
    {
        return base.getWorkingDays();
    }

    public override float CalculatePayableAmount(int WorkingDays)
    {
        return WorkingDays * (MINIMUM_PER_HOUR_RATE + 75);
    }
}
public class ContractualEmployeeWage : BillingBase
{
    public override float CalculatePayableAmount(int na)
    {
        return (MINIMUM_PER_HOUR_RATE + 25) * 30.25F;
    }
}