namespace akasia_core;

public static class JewelsExtensions
{
    public static decimal CalculateMaximumIncome(this List<Jewel> jewels,Dictionary<JewelType, decimal> jewelPairPrices)
    {
        decimal maximumIncome = 0;

       

        var groupedJewels = jewels.GroupBy(j => j.JewelType);

        foreach (var group in groupedJewels)
        {
            int pairCount = group.Sum(j => j.Quantity / 2);
            decimal income = pairCount * jewelPairPrices[group.Key];
            maximumIncome += income;

            int remainingQuantity = group.Sum(j => j.Quantity % 2);
            if (remainingQuantity == 1)
            {
                decimal singleJewelPrice = jewelPairPrices[group.Key] / 2;
                // maximumIncome += singleJewelPrice;
            }
        }

        return maximumIncome;
    }
}