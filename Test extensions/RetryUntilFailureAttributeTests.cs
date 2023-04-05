using NUnit.Framework;
using nunit_debugging_extensions;

namespace Test_extensions;

[TestFixture]
public class RetryUntilFailureAttributeFixture
{
    private int _counter;

    [Test, RetryUntilFailure, Ignore("Test should fail when run")]
    public void RunUntilFailure_ShouldFail()
    {
        // Act + Assert
        Assert.IsTrue(_counter <= 10);
        _counter++;
    }

    [Test, RetryUntilFailure(20), Ignore("Test should fail when run")]
    public void HitFailureBeforeMaxRetries_ShouldFail()
    {
        // Act + Assert
        Assert.IsTrue(_counter <= 10);
        _counter++;
    }

    [Test, RetryUntilFailure(5)]
    public void HitMaxRetriesBeforeFailure_ShouldPass()
    {
        // Act + Assert
        Assert.IsTrue(_counter <= 10);
        _counter++;
    }
}
