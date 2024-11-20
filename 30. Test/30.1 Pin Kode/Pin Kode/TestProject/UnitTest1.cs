using CardTerminal;

namespace TestProject;

public class Tests
{
	[SetUp]
	public void Setup ()
	{
	}

	[Test]
	public void PinExpendNormalTest ()
	{
		Pin pin = new Pin();

		Assert.That(pin.Expend(42), Is.False);
	}
	
	[Test]
	public void PinExpendMaximumTest ()
	{
		Pin pin = new Pin();

		Assert.That(pin.Expend(420), Is.True);
	}
	
	[Test]
	public void PinExpendCriticalTest ()
	{
		Pin pin = new Pin();

		Assert.That(pin.Expend(350), Is.False);
	}
	

	[Test]
	public void PinExpendCriticalTest2 ()
	{
		Pin pin = new Pin();

		Assert.That(pin.Expend(351), Is.True);
	}

	[Test]
	public void PinExpendAmountTest ()
	{
		Pin pin = new Pin();

		Assert.That(pin.Expend(1000), Is.True);
		Assert.That(pin.Expend(1000), Is.True);
		Assert.That(pin.Expend(1000), Is.True);
		Assert.That(pin.Expend(10), Is.False);
	}
}