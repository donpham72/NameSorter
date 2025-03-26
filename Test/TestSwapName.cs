using NameSorter;

namespace Test;

public class TestSwapName
{
    [Fact]
    public void TestGetLastFirstName()
    {
        string name1 = "Janet Parsons";
        string result1 = Helper.GetLastFirstName(name1);
        Assert.Equal("Parsons Janet", result1);

        string name2 = "Adonis Julius Archer";
        string result2 = Helper.GetLastFirstName(name2);
        Assert.Equal("Archer Adonis Julius", result2);

        string name3 = "Hunter Uriah Mathew Clarke";
        string result3 = Helper.GetLastFirstName(name3);
        Assert.Equal("Clarke Hunter Uriah Mathew", result3);
    }

    [Fact]
    public void TestGetFirstLastName()
    {
        string name1 = "Parsons Janet";
        string result1 = Helper.GetFirstLastName(name1);
        Assert.Equal("Janet Parsons", result1);

        string name2 = "Archer Adonis Julius";
        string result2 = Helper.GetFirstLastName(name2);
        Assert.Equal("Adonis Julius Archer", result2);

        string name3 = "Clarke Hunter Uriah Mathew";
        string result3 = Helper.GetFirstLastName(name3);
        Assert.Equal("Hunter Uriah Mathew Clarke", result3);
    }
}
