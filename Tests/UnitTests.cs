namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

public class SubtractTests
{
    [TestMethod]
    public void Subtract_Valid_Patino()
    {
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(-5, Program.Subtract("2", "7"));
    }

    [TestMethod]
    public void Subtract_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
    }

    [TestMethod]
    public void Subtract_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null!));
    }
}

[TestClass]
public class MultiplyTests
{
    [TestMethod]
    public void Multiply_Valid_Patino()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(0, Program.Multiply("5", "0"));
    }

    [TestMethod]
    public void Multiply_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("x", "3"));
    }

    [TestMethod]
    public void Multiply_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null!, "3"));
    }
}

[TestClass]
public class DivideTests
{
    [TestMethod]
    public void Divide_Valid_Patino()
    {
        Assert.AreEqual(2, Program.Divide("10", "5"));
    }

    [TestMethod]
    public void Divide_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("10", "y"));
    }

    [TestMethod]
    public void Divide_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null!, "2"));
    }

    [TestMethod]
    
	public void Divide_By_Zero()
	{
		var result = Program.Divide("10", "0");
		Assert.IsTrue(double.IsInfinity(result));
	}
}

[TestClass]
public class PowerTests
{
    [TestMethod]
    public void Power_Valid_Patino()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
    }

    [TestMethod]
    public void Power_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
    }

    [TestMethod]
    public void Power_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null!, "3"));
    }
}
