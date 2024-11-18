namespace Wpm.SharedKernel;

// Value object - oprettes som record (som er immutable)
public record Weight
{
    public decimal Value { get; init; }

    public Weight(decimal value)
    {
        if (value < 0) throw new ArgumentException("Weight needs to be positive");

        Value = value;
    }

    public static implicit operator Weight(decimal value)
    {
        return new Weight(value);
    }
}