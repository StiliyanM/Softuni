using NUnit.Framework;
using System.Text;

public class Class1
{
    private IProviderController providerController;

    [SetUp]
    public void SetUp()
    {
        providerController = new ProviderController(new ProviderFactory(), new EnergyRepository());
    }

    [Test]
    public void RegisterProviderValidTest()
    {
        var sb = new StringBuilder();

        sb.AppendLine(providerController.Register("Pressure 40 100".Split()))
                    .AppendLine(providerController.Register("Solar 20 100".Split()))
                    .AppendLine(providerController.Register("Standart 10 100".Split()));

        var expected = new StringBuilder()
            .AppendLine("Successfully registered PressureProvider")
            .AppendLine("Successfully registered SolarProvider")
            .AppendLine("Successfully registered StandartProvider")
            .ToString().TrimEnd();

        var actual = sb.ToString().TrimEnd();

        Assert.AreEqual(expected, actual);
    }
}

