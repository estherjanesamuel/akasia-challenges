using akasia_core;

namespace akasia_test;

[TestFixture]
public class IntUtilsTests
{
    [Test]
    public void ShouldReturnProduct_WhenInputNumber()
    {
        // assign
        int j = 2;
        int k = 4;
        var product = new IntUtils();
        
        // actual
        int result = product.perkalianSederhana(j,k);
        
        // assert
        Assert.That(result, Is.EqualTo(8));
    }
}