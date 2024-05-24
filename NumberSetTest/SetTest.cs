using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSet;

namespace NumberSetTest;

[TestClass]
public class SetTests{
    [TestMethod]
    public void TestSetConstructor(){
        Set s1 = new Set();
        Assert.IsNotNull(s1);
    }

    [TestMethod]
    public void TestInsertElement(){
        Set s1 = new Set();
        s1.InsertElement(1);
        Assert.IsTrue(s1.IsElementInTheSet(1));
    }

    [TestMethod]
    public void TestInsertElementTwice(){
        Set s1 = new Set();
        s1.InsertElement(1);
        Assert.ThrowsException<Set.ElementAlreadyInSetException>(() => s1.InsertElement(1));
    }
    
    [TestMethod]
    public void TestIsElementInTheSet(){
        Set s1 = new Set();
        s1.InsertElement(1);
        Assert.IsTrue(s1.IsElementInTheSet(1));
        Assert.IsFalse(s1.IsElementInTheSet(2));
    }

    [TestMethod]
    public void TestRemoveElement(){
        Set s1 = new Set();
        s1.InsertElement(1);
        s1.RemoveElement(1);
        Assert.IsFalse(s1.IsElementInTheSet(1));
    }

    [TestMethod]
    public void TestRemoveElementTwice(){
        Set s1 = new Set();
        s1.InsertElement(1);
        s1.RemoveElement(1);
        Assert.ThrowsException<Set.ElementNotInSetException>(() => s1.RemoveElement(1));
    }

    [TestMethod]
    public void TestRemoveElementNotInSet(){
        Set s1 = new Set();
        Assert.ThrowsException<Set.ElementNotInSetException>(() => s1.RemoveElement(1));
    }

    [TestMethod]
    public void TestIsEmpty(){
        Set s1 = new Set();
        Assert.IsTrue(s1.IsEmpty());
        s1.InsertElement(1);
        Assert.IsFalse(s1.IsEmpty());
    }

    [TestMethod]
    public void TestGetRandomElement(){
        Set s1 = new Set();
        s1.InsertElement(1);
        Assert.AreEqual(1, s1.GetRandomElement());
    }

    [TestMethod]
    public void TestGetRandomElementTwice(){
        Set s = new Set();
        s.InsertElement(2);
        s.InsertElement(4);
        s.InsertElement(6);
        int randomElement = s.GetRandomElement();
        Assert.IsTrue(s.IsElementInTheSet(randomElement));
}

    [TestMethod]
    public void TestGetRandomElementEmptySet(){
        Set s1 = new Set();
        Assert.ThrowsException<Set.EmptySetException>(() => s1.GetRandomElement());
    }

    [TestMethod]
    public void TestGetEvenCount(){
        Set s1 = new Set();
        s1.InsertElement(1);
        s1.InsertElement(2);
        s1.InsertElement(3);
        Assert.AreEqual(1, s1.GetEvenCount());
    }  

    [TestMethod]
    public void TestPrintElements(){
        Set s1 = new Set();
        s1.InsertElement(1);
        s1.InsertElement(2);
        s1.InsertElement(3);
        try{
            s1.PrintElements();
            Assert.IsTrue(true);
        } catch {
            Assert.Fail("Exception was thrown");
        }
    }

    [TestMethod]
    public void TestIsEven(){
        Assert.IsTrue(Set.IsEven(2));
        Assert.IsFalse(Set.IsEven(3));
    }

  
}

