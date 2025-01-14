namespace GeneralLabSolutions.Domain.Extensions.Helpers.Dtos.Dtoskanban
{
    public class TarefaStatusUpdateDto
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
