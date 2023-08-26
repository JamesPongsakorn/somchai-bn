namespace somchai_bn.Model;

public class PostTransactionRequest
{
    public decimal amount { get; set; }
    public List<PersonEntity> person { get; set; } = null!;
}