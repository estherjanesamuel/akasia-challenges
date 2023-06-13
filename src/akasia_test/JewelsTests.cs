using akasia_core;

namespace akasia_test;

[TestFixture]
public class JewelsTests
{
    
    [Test]
    public void ShouldReturn2000K_WhenSale4JewelTypeRuby_WithQty5()
    {
        // assign 
        var jewelPairPrices = new Dictionary<JewelType, decimal>
        {
            { JewelType.Ruby, 1000000 },
            { JewelType.Topaz, 1250000 },
            { JewelType.Permata, 3000000 }
        };

        List<KawanLamaJewel> jewels = new List<KawanLamaJewel>
        {
            new KawanLamaJewel { JewelType = JewelType.Ruby, Quantity = 5},
        };

        // actual
        var got = jewels.CalculateMaximumIncome(jewelPairPrices);

        // assert
        Assert.That(got, Is.EqualTo(2000000));
    }
}