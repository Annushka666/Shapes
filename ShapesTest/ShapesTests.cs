using Shapes;
namespace ShapesTest
{
    public class ShapesTests
    {
        public class ShapeTests
        {
            [Fact]
            public void CircleArea_ShouldBeCorrect() //��������� ���������� ������� �����
            {
                var circle = new Circle(5);
                double expectedArea = Math.PI * 5 * 5;
                Assert.Equal(expectedArea, circle.GetArea(), precision: 5);
            }

            [Fact]
            public void TriangleArea_ShouldBeCorrect()//�������� ���������� ������� ������������
            {
                var triangle = new Triangle(3, 4, 5);
                double expectedArea = 6;
                Assert.Equal(expectedArea, triangle.GetArea(), precision: 5);
            }

            [Fact]
            public void Triangle_ShouldBeRight()//�������� ������������ ������������
            {
                var triangle = new Triangle(3, 4, 5);
                Assert.True(triangle.IsRightTriangle());
            }

            [Fact]
            public void Triangle_ShouldNotBeRight()// �������� ������������� ������������
            {
                var triangle = new Triangle(3, 4, 6);
                Assert.False(triangle.IsRightTriangle());
            }

            [Fact]
            public void AreaCalculator_ShouldWorkWithDifferentShapes()
            {
                var circle = new Circle(10);
                var triangle = new Triangle(3, 4, 5);

                Assert.Equal(Math.PI * 10 * 10, AreaCalculator.CalculateArea(circle), precision: 5);
                Assert.Equal(6, AreaCalculator.CalculateArea(triangle), precision: 5);
            }
        }
    }
}