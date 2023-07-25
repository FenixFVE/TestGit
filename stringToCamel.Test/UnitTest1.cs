namespace stringToCamel.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.That(strtingToCamel.App.Program.ToCamelCase("this_is_a_string"), Is.EqualTo("thisIsAString"));
    }
}