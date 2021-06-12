using AppService;
using Moq.AutoMock;
using System;
using Xunit;

namespace TestArea
{
    public class ValidarAreaTest
    {
        [Fact(DisplayName = "Validar Calculo")]
        [Trait("Categoria", "Valor")]
        public void Area_ValorCorreto()
        {
            // Arrange
            var mocker = new AutoMocker();
            var gerenciamento = mocker.CreateInstance<AreaService>();

            // Act
            var area = gerenciamento.CalcularAreaCirculo(1);

            // Assert
            Assert.True(area == Math.PI);

        }
    }
}
