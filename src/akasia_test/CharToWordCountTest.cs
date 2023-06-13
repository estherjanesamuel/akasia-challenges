using akasia_core;

namespace akasia_test;

[TestFixture]
public class CharToWordCountTest
{

    [Test]
    public void ShouldReturn_2_WhenInputStr_USOMAANAPAIUMASYDNIP()
    {
        // assign
        string str = "USOMAANAPAIUMASYDNIP";
        // act
        int cnt = str.CntWordFromStr(word: "SIAPA");
        // assert
        Assert.That(cnt, Is.EqualTo(2));
    }

}