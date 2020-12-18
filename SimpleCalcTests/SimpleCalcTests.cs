using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUnitTest
{
    class SimpleCalcTests
    {
        private SimpleCalc.SimpleCalc simpleCalc = new SimpleCalc.SimpleCalc();
        public bool plusTest()
        {
            if (simpleCalc.add(0, 5) != 5)
                return false;
            if (simpleCalc.add(-3, 8) != 5)
                return false;
            if (simpleCalc.add(23, 20) != 43)
                return false;
            if (simpleCalc.add(33333, 22222) != 55555)
                return false;
            if (simpleCalc.add(5, 0) != 5)
                return false;
            if (simpleCalc.add(8, -5) != 3)
                return false;
            if (simpleCalc.add(26, 50) != 76)
                return false;
            if (simpleCalc.add(-6, -5) != -11)
                return false;
            if (simpleCalc.add(-22222, -22222) != -44444)
                return false;
            if (simpleCalc.add(0, 0) != 0)
                return false;

            return true;
        }
        public bool minusTest()
        {
            if (simpleCalc.sub(5, 3) != 2)
                return false;
            if (simpleCalc.sub(5, 9) != -4)
                return false;
            if (simpleCalc.sub(0, 3) != -3)
                return false;
            if (simpleCalc.sub(5, 0) != 5)
                return false;
            if (simpleCalc.sub(-5, -3) != -2)
                return false;
            if (simpleCalc.sub(555, 444) != 111)
                return false;
            if (simpleCalc.sub(5, -3) != 8)
                return false;
            if (simpleCalc.sub(-50, 3) != -53)
                return false;
            if (simpleCalc.sub(15, 23) != -8)
                return false;
            if (simpleCalc.sub(0, 0) != 0)
                return false;
            return true;
        }
        public bool multiTest()
        {
            if (simpleCalc.multi(0, 3) != 0)
                return false;
            if (simpleCalc.multi(0, 0) != 0)
                return false;
            if (simpleCalc.multi(7, 0) != 0)
                return false;
            if (simpleCalc.multi(5, 3) != 15)
                return false;
            if (simpleCalc.multi(4, -3) != -12)
                return false;
            if (simpleCalc.multi(-4, 5) != -20)
                return false;
            if (simpleCalc.multi(-3, -3) != 9)
                return false;
            if (simpleCalc.multi(44, 2) != 88)
                return false;
            if (simpleCalc.multi(-20, 3) != -60)
                return false;
            if (simpleCalc.multi(50, 3) != 150)
                return false;
            return true;
        }
        public bool divideTest()
        {
            if (simpleCalc.divide(0, 3) != 0)
                return false;
            if (simpleCalc.divide(1, 4) != (decimal)0.25)
                return false;
            if (simpleCalc.divide(7, 1) != 7)
                return false;
            if (simpleCalc.divide(6, 3) != 2)
                return false;
            if (simpleCalc.divide(4, -2) != -2)
                return false;
            if (simpleCalc.divide(-20, 5) != -4)
                return false;
            if (simpleCalc.divide(-30, -3) != 10)
                return false;
            if (simpleCalc.divide(44, 2) != 22)
                return false;
            if (simpleCalc.divide(-20, 8) != (decimal)-2.5)
                return false;
            if (simpleCalc.divide(50, 5) != 10)
                return false;
            return true;
        }
        public bool selectionPlusTest()
        {
            if (simpleCalc.OperatorSwitch(30, 23, "+") != "53")
                return false;
            return true;
        }
        public bool selectionMinusTest()
        {
            if (simpleCalc.OperatorSwitch(30, 23, "-") != "7")
                return false;
            return true;
        }
        public bool selectionMultiTest()
        {
            if (simpleCalc.OperatorSwitch(30, 3, "*") != "90")
                return false;
            return true;
        }
        public bool selectionDivideTest()
        {
            if (simpleCalc.OperatorSwitch(30, 5, "/") != "6")
                return false;
            return true;
        }
        public bool selectionDivideByZeroTest()
        {
            if (simpleCalc.OperatorSwitch(30, 0, "/") != "error!. divided by zero")
                return false;
            return true;
        }
    }
}
