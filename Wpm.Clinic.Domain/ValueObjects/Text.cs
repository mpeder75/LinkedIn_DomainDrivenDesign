namespace Wpm.Clinic.Domain.ValueObjects;

public record Text
{
    public string Value { get; init; }

    public Text(string value)
    {
        Validate(value);
        Value = value;
    }

    private void Validate(string value)
    {
        // Validation for whitespace and length
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException("value", "Text is not valid");
        }

        if (value.Length > 100)
        {
            throw new ArgumentException("Value cannot be longer than 100 characters");
        }
    }

    public static implicit operator Text(string value)
    {
        return new Text(value);
    }
}