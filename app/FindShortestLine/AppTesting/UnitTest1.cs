using FindShortestLine.Classes;

namespace AppTesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod()
        {
            // Arrange
            Graph graph = new Graph(3);
            double[,] m = {
            {0, 4, 2} ,  
            {4, 0, 1} ,  
            {2, 1, 0}  
                };
            graph.incidenceMatrix = m;

            // Act
            double result = graph.ComparePoints(0, 1);
            // Assert
            Assert.Equal(3, result);
        }
    }
}
