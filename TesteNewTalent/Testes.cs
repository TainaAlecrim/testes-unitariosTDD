using NewTalents;

namespace TesteNewTalent
{
    public class Testes
    {
        public Calculadora contruirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(5, 2, 7)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = contruirClasse();

            int resultadoCalculadora = calc.somar(val1,val2);

            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 2, 10)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc =  contruirClasse();

            int resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(10, 2, 5)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc =  contruirClasse();

            int resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultadoCalculadora, resultado);
        }

        [Theory]
        [InlineData(8, 2, 6)]
        [InlineData(10, 2, 8)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc =  contruirClasse();

            int resultadoCalculadora = calc.subtrait(val1, val2);

            Assert.Equal(resultadoCalculadora, resultado);
        }


        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc =  contruirClasse();


            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3,0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = contruirClasse();


            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(9, 10);
            calc.somar(7, 5);

            var lista = calc.historico();

            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}