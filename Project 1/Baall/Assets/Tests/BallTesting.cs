using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class BallTesting
{
    // A Test behaves as an ordinary method
    [Test]
    public void BallDefaultConstructorTest()
    {
        GameObject defaultBall = new Ball().GetGO();

        Assert.AreEqual(.0001f, defaultBall.GetComponent<Rigidbody>().mass);
        Assert.AreEqual(0, defaultBall.GetComponent<Rigidbody>().drag);
        Assert.AreEqual(0, defaultBall.GetComponent<Rigidbody>().angularDrag);
        Assert.AreEqual("ball", defaultBall.tag);
    }

    [Test]
    public void BallCustomConstructorTest()
    {
        GameObject customBall = new Ball(1,2,3,4).GetGO();

        Assert.AreEqual(1, customBall.GetComponent<Rigidbody>().mass);
        Assert.AreEqual(2, customBall.GetComponent<Rigidbody>().drag);
        Assert.AreEqual(3, customBall.GetComponent<Rigidbody>().angularDrag);
        Assert.AreEqual("ball", customBall.tag);
    }

    [Test]
    public void PlayerDefaultConstructorTest()
    {
        Players defaultPlayer = new Players();

        Assert.AreEqual(null, defaultPlayer.GetGO());
        Assert.AreEqual(0, defaultPlayer.GetGoal());

    }

    [Test]
    public void PlayerCustomConstructorTest()
    {
        GameObject player = new GameObject();
        Players CustomPlayer = new Players();
        CustomPlayer.PlayerSet(player,2);

        Assert.AreEqual(player, CustomPlayer.GetGO());
        Assert.AreEqual(2, CustomPlayer.GetGoal());

    }
    
    
    
}
