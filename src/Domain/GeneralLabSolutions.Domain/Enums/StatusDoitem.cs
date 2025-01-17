
using System.ComponentModel;

namespace GeneralLabSolutions.Domain.Enums
{
    public enum StatusDoItem
    {
        [Description("Item Pago")] Pago, // Peso: 30 - mais alto (prioritário)
        [Description("Entregue")] Entregue, // Peso: 20 - grande
        [Description("Aguardando a Transportadora")] AguardandoTransportadora, // Peso: 5 - mínimo (raridade)

        [Description("Em Revisao")] EmRevisao, // Peso: 8 - maior que AguardandoTransportadora
        [Description("Em Transito")] EmTransito, // Peso: 10 - maior que EmRevisao
        [Description("Na Alfândega")] NaAlfandega, // Peso: 15 - maior que EmTransito
        // Adicione outros estados conforme necessário
    }
}
