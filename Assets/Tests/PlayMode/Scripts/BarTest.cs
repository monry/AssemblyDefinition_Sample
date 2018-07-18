using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class BarTest
{
    [UnityTest]
    public IEnumerator PlayModeTest()
    {
        Assert.Pass();
        yield break;
    }
}