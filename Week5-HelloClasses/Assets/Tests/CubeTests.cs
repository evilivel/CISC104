using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CubeTests
{
    // Test the default constructor
    [Test]
    public void CubeDefaultConstructorTest()
    {
        // Setup and Act
        Cube defaultCube = new Cube();

        // Assert
        Assert.AreEqual(0, defaultCube.GetHeight());
        Assert.AreEqual(0, defaultCube.GetWidth());
        Assert.AreEqual(0, defaultCube.GetLength());
        Assert.AreEqual(0, defaultCube.Getedge());
        Assert.AreEqual(0, defaultCube.GetVolume());
    }

    // Test a 2 x 4 Cube
    [Test]
    public void CubeTwoByFourTest()
    {
        // Setup and Act
        Cube twoByFour = new Cube(2f, 4f, 6f);

        // Assert
        Assert.AreEqual(2, twoByFour.GetHeight());
        Assert.AreEqual(4, twoByFour.GetWidth());
        Assert.AreEqual(6, twoByFour.GetLength());
        Assert.AreEqual(48, twoByFour.Getedge());
        Assert.AreEqual(48, twoByFour.GetVolume());
    }

    // Test a 10 x 10 Cube
    [Test]
    public void CubeTenByTenTest()
    {
        // Setup and Act
        Cube tenByTen = new Cube(10f, 10f, 10f);

        // Assert
        Assert.AreEqual(10, tenByTen.GetHeight());
        Assert.AreEqual(10, tenByTen.GetWidth());
        Assert.AreEqual(10, tenByTen.GetLength());
        Assert.AreEqual(120, tenByTen.Getedge());
        Assert.AreEqual(1000, tenByTen.GetVolume());
    }

    // Test the SetHeight method
    [Test]
    public void CubeSetHeightTest()
    {
        // Setup
        Cube someCube = new Cube(1, 5, 9);

        // Act
        someCube.SetHeight(100);

        // Assert
        Assert.AreEqual(100, someCube.GetHeight());

        Assert.AreEqual(5, someCube.GetWidth());
        Assert.AreEqual(456, someCube.Getedge());
        Assert.AreEqual(4500, someCube.GetVolume());
    }
}
