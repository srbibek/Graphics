using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI_Application;
using System.Drawing;

namespace GUI_Application.Unit_Testing
{
    [TestClass]
    public class CircleTest
    {
        int texturestyle = 0;
        Color paintcolor = Color.Black;
        Brush bb;
        [TestMethod]
        public void TestMethod1()
        {
            var Circle = new Circle();
            int x=200, y=200, size=200, size1=200;
            Circle.set(texturestyle, bb, paintcolor,x, y, size, size1);
            Assert.AreEqual(200, Circle.x);
        }
    }
}
