using NewTalents;

namespace TestNewTalent
{
    public class UnitTest1
    {
   
          public Calculadora construirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora("02/02/2020");

            return calc;
        }
            

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void TesteSoma(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            resultado = calc.somar(val1, val2);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void Test2()
        {
            Calculadora calc = construirClasse();

            int resultado = calc.somar(1, 2);

            Assert.Equal(9, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            resultado = calc.multiplicar(val1, val2);

            Assert.Equal(3, resultado);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(6, 5, 1)]
        public void TesteSubitrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            resultado = calc.subtrair(val1, val2);

            Assert.Equal(3, resultado);
        }


        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(10, 2, 5)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            resultado = calc.dividir(val1, val2);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse(); 

            Assert.NotEmpty(calc.historico());

            calc.somar(1, 2);
            calc.somar(5, 2);
            calc.somar(4, 3);
            calc.somar(3, 2);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count());

        }

    }
}
