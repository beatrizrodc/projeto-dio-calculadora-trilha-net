using CalculadoraMain;

namespace CalculadoraTest
{
    public class ValidacaoCalculadora
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        [InlineData(7, 6, 13)]
        public void validacaoSeSomaEstaRetornandoCorretamente(int num1, int num2, int resultado)
        {
            Calculadora _calc = new Calculadora();
            int resultadoDaCalculadora = _calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoDaCalculadora);
        } 
        
        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(25, 5, 5)]
        [InlineData(70, 7, 10)]
        public void validacaoSeDivisaoEstaRetornandoCorretamente(int num1, int num2, int resultado)
        {
            Calculadora _calc = new Calculadora();
            int resultadoDaCalculadora = _calc.dividir(num1, num2);

            Assert.Equal(resultado, resultadoDaCalculadora);
        } 
        
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(15, 5, 10)]
        [InlineData(17, 6, 11)]
        public void validacaoSeSubtracaoEstaRetornandoCorretamente(int num1, int num2, int resultado)
        {
            Calculadora _calc = new Calculadora();
            int resultadoDaCalculadora = _calc.subtrair(num1, num2);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }
        
        [Theory]
        [InlineData(6, 2, 12)]
        [InlineData(4, 5, 20)]
        [InlineData(7, 7, 49)]
        public void validacaoSeMultiplicacaoEstaRetornandoCorretamente(int num1, int num2, int resultado)
        {
            Calculadora _calc = new Calculadora();
            int resultadoDaCalculadora = _calc.multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Fact]

        public void validacaoHistorico() 
        {
            Calculadora _calc = new Calculadora();

            _calc.somar(1, 2);
            _calc.somar(6, 5);
            _calc.somar(5, 4);
            _calc.somar(7, 3);

            var lista = _calc.historico();

            Assert.NotEmpty(_calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}