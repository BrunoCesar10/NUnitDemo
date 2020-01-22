using NUnit.Framework;

namespace NUnitTestDemo
{
    [TestFixture]
    public class NUnitDemo
    {
        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(1, 2, 3)]
        [TestCase(12, 20, 32)]
        public void TestMethodSoma(int num1, int num2, int res)
        {
            int obtido, esperado = res;
            ClassLibraryNUnit.ClasseParaNUnit target = new ClassLibraryNUnit.ClasseParaNUnit();
            obtido = target.Soma(num1, num2);
            Assert.AreEqual(obtido, esperado);
        }

        [Test]
        public void TestMethodConcatenacao()
        {
            string obtido, esperado = "Hello World and Brazil";
            ClassLibraryNUnit.ClasseParaNUnit target = new ClassLibraryNUnit.ClasseParaNUnit();
            obtido = target.Concatenacao("World", "and Brazil");
            Assert.AreEqual(obtido, esperado);
        }

        [Test]
        public void TestMethodSubtracao()
        {
            int obtido, esperado = -2;
            ClassLibraryNUnit.ClasseParaNUnit target = new ClassLibraryNUnit.ClasseParaNUnit();
            obtido = target.Subtracao(5, 7);
            Assert.AreEqual(obtido, esperado);
        }

        [Test]
        public void TestMethodMultiplicacao()
        {
            int obtido, esperado = 24;
            ClassLibraryNUnit.ClasseParaNUnit target = new ClassLibraryNUnit.ClasseParaNUnit();
            obtido = target.Multiplicacao(3, 8);
            Assert.AreEqual(obtido, esperado);
            obtido = target.Multiplicacao(8, 3);
            Assert.AreEqual(obtido, esperado);
        }

        [Test]
        public void TestMethodDivisao()
        {
            int obtido, esperado = 8;
            ClassLibraryNUnit.ClasseParaNUnit target = new ClassLibraryNUnit.ClasseParaNUnit();
            obtido = target.Divisao(40, 5);
            Assert.AreEqual(obtido, esperado);
        }
    }
}
