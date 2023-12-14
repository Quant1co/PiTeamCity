using PIteamcity;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckFermatTheorem_ForNEqualOne_ShouldPrintTheoremHolds()
        {
            // Arrange
            var expectedOutput = "Fermat's theorem holds for all numbers up to 1";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            Program.CheckFermatTheorem(1);
            var actualOutput = consoleOutput.ToString().Trim();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void CheckFermatTheorem_ForNEqualTwo_ShouldPrintTheoremHolds()
        {
            // Arrange
            var expectedOutput = "Fermat's theorem holds for all numbers up to 2";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            Program.CheckFermatTheorem(2);
            var actualOutput = consoleOutput.ToString().Trim();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void CheckFermatTheorem_ForNEqualThree_ShouldPrintTheoremHolds()
        {
            // Arrange
            var expectedOutput = "Fermat's theorem holds for all numbers up to 3";
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            Program.CheckFermatTheorem(3);
            var actualOutput = consoleOutput.ToString().Trim();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}