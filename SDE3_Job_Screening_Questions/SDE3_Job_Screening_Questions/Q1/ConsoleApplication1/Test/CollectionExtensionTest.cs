using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace Test
{
    [TestFixture]
    public class CollectionExtensionTest
    {
        [Test]
        public void Test_In_WhenNull_ReturnsFalse()
        {
            //Arrange
            object[] param = null;
            int variableUnderTest = 1;

            //Act
            var result = variableUnderTest.In(param);

            //Assert
            Assert.That(result, Is.False);
            Assert.That(result, Is.EqualTo(false));
            //Assert.That(result, Is.Null);
            //Assert.That(result, Is.Not.Null);

        }

        [Test]
        public void Test_In_WhenNotFound_ReturnsFalse()
        {
            //Arrange
            object[] param = new object[]{0};
            int variableUnderTest = 1;

            //Act
            var result = variableUnderTest.In(param);

            //Assert
            Assert.That(result, Is.False);

        }
        [Test]
        public void Test_In_WhenNotFound_ReturnsFalse_ForEnum()
        {
            //Arrange
            object[] param = new object[] { MyFruitEnum.Orange, MyFruitEnum.Banana };
            MyFruitEnum classUnderTest = MyFruitEnum.Apple;

            //Act
            var result = classUnderTest.In(param);

            //Assert
            Assert.That(result, Is.False);

        }
         [Test]
        public void Test_In_WhenFound_ReturnsTrue_ForEnum()
        {
            //Arrange
            object[] param = new object[] { MyFruitEnum.Orange, MyFruitEnum.Banana };
            MyFruitEnum classUnderTest = MyFruitEnum.Banana;

            //Act
            var result = classUnderTest.In(param);

            //Assert
            Assert.That(result, Is.True);

        }
        [Test]
         public void Test_In_WhenFound_ReturnsTrue_ForString()
         {
             //Arrange
             object[] param = new object[] { "foo", "bar", "baz", "qux" };
             string classUnderTest = "qux";

             //Act
             var result = classUnderTest.In(param);

             //Assert
             Assert.That(result, Is.True);

         }

        [Test]
        public void Test_In_WhenNoParam_ReturnsFalse_ForString()
        {
            //Arrange
            object[] param = new object[] { "foo", "bar", "baz", "qux" };
            string classUnderTest = "qux";

            //Act
            var result = classUnderTest.In();

            //Assert
            Assert.That(result, Is.False);

        }
        [Test]
        public void Test_Pos_WhenNoParam_ReturnsMinusOne_ForString()
        {
            //Arrange
            object[] param = new object[] { "foo", "bar", "baz", "qux" };
            string classUnderTest = "qux";

            //Act
            var result = classUnderTest.Pos();

            //Assert
            Assert.That(result, Is.EqualTo(-1));

        }
         [Test]
         public void Test_Pos_WhenFound_ReturnsIndexPosition_ForChar()
         {
             //Arrange
             object[] param = new object[] { 'x', 'y', 'z' };
             char variableUnderTest = 'y';
             //Act
             var result = variableUnderTest.Pos(param);

             //Assert
             Assert.That(result, Is.EqualTo(1));

         }
         [Test]
         public void Test_Pos_WhenFound_ReturnsIndexPosition_ForEnum()
         {
             //Arrange
             object[] param = new object[] {3, 8, 11, 9};
             int variableUnderTest = 9;
             //Act
             var result = variableUnderTest.Pos(param);

             //Assert
             Assert.That(result, Is.EqualTo(3));

         }

        [Test]
        public void Test_Pos_WhenNull_ReturnsMinusOne()
        {
            //Arrange
            object[] param = null;
            int variableUnderTest = 1;

            //Act
            var result = variableUnderTest.Pos(param);

            //Assert
            Assert.That(result, Is.EqualTo(-1));

        }

        [Test]
        public void Test_Pos_WhenNotFound_ReturnsMinusOne()
        {
            //Arrange
            object[] param = new object[] { 0 };
            int variableUnderTest = 1;

            //Act
            var result = variableUnderTest.Pos(param);

            //Assert
            Assert.That(result, Is.EqualTo(-1));

        }
    }
}
