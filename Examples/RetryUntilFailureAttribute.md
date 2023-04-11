# RetryUntilFailureAttribute

Runs a test until it fails.<br>

```
[TestFixture]
public class RetryUntilFailureAttributeFixture
{
    private int _counter = 0;

    [Test, RetryUntilFailure]
    public void RunUntilFailure_ShouldFail()
    {
        Assert.IsTrue(_counter <= 10);
    }
}
```

<br>In this example it will run forever, if we make a small cahnge it will stop from running only where the test fails:<br>

```
[TestFixture]
public class RetryUntilFailureAttributeFixture
{
    private int _counter = 0;

    [Test, RetryUntilFailure]
    public void RunUntilFailure_ShouldFail()
    {
        Assert.IsTrue(_counter <= 10);
        _counter++;
    }
}
```

<br>If you want to limit the amount of runs you can do something like this:<br>

```
[TestFixture]
public class RetryUntilFailureAttributeFixture
{
    private int _counter = 0;

    [Test, RetryUntilFailure(5)]
    public void RunUntilFailure_ShouldFail()
    {
        Assert.IsTrue(_counter <= 10);
        _counter++;
    }
}
```

<br>Even if the test didn't fail it will stop after 5 runs from that example.