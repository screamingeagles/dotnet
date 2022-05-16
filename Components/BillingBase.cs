public abstract class BillingBase
{
    const float MINIMUM_PER_HOUR_RATE = 7.25;       // Federally mandated US minimium per hour wage
    public int getWorkingDays()
    {
        Random rand = new Random();
        return rand.Next(28, 31);
    }
    public abstract float CalculatePayableAmount(int WorkingDays);
}
public class PermanentEmployeeWage : BillingBase
{
    private int getWorkingDays()
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
    private int getWorkingDays()
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
        return (MINIMUM_PER_HOUR_RATE + 25) * 30.25;
    }
}