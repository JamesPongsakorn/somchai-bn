namespace somchai_bn.Model;

public class GetTransactionResponse
{
    public string transaction { get; set; } = string.Empty;
    public List<PersonEntity> person { get; set; } = null!;
}