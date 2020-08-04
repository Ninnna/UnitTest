using Moq;
using System;
using UnitTest;
using Xunit;

namespace XUnitTestProject1
{
    public class StudentServiceTest
    {

        [Fact]
        public void GetAll_Returns_Data()
        {
            //Arrange
            var svc = new StudentService(new FakeStudentRepository());

            //Act
            var result = svc.GetAll();

            //Assert
            Assert.Equal(2, result.Count);
        }

        //[Theory]
        //[InlineData(-2,2,0)]
        //[InlineData(3,4,7)]
        //[InlineData(1,1,1)]
        //public void canAddByTheory(int value1, int value2, int expected)
        //{
        //    var myClass = new MyClass();
        //    var result = myClass.Add(value1, value2);
        //    Assert.Equal(result, expected);
        //}
        
        //[Fact]
        //public void isPositive()
        //{
        //    var classMock = new Mock<Test>();
        //    classMock.Setup(x => x.Method()).Retutns(0);
        //}
    }
}
