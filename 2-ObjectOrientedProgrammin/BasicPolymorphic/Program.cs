class Employee
{
    private float Pay;

    public virtual void GiveBonus(float amount) => Pay += amount;
}

class SalesPerson : Employee
{
    public sealed override void GiveBonus(float amount)
    {
        int salesBonus = 5;
        base.GiveBonus(amount * salesBonus);
    }
}

class Manager : Employee
{
    public override void GiveBonus(float amount)
    {
        int salesBonus = 5;
        base.GiveBonus(amount * salesBonus);
    }
}

class SalesPersonChild : SalesPerson
{
    // Compiler error! Can't override this method
    // in the SalesPerson class, as it was sealed.
    // public override void GiveBonus(float amount)
    // {
    //     base.GiveBonus(amount);
    // }
}