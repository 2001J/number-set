using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSet;
namespace NumberSetTest;

[TestClass]
public class SetOperationsTests{
    [TestMethod]
    public void TestSetOperationsConstructor(){
        SetOperations so1 = new SetOperations();
        Assert.IsNotNull(so1);
    }

}