namespace Wpm.Clinic.Domain.ValueObjects;

public record VitalSigns
{
    public DateTime ReadingDateTime { get; init; }
    public decimal Temperature { get; init; }
    public int HeartRated { get; init; }
    public int RespiratoryRate { get; init; }

    public VitalSigns(DateTime readingDateTime, decimal temperature, int heartRated, int respiratoryRate)
    {
        ReadingDateTime = readingDateTime;
        Temperature = temperature;
        HeartRated = heartRated;
        RespiratoryRate = respiratoryRate;
    }
}