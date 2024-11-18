using Wpm.Clinic.Domain.Entities;

namespace Wpm.Clinic.Domain.Tests;

public class ConsultationTest
{
    [Fact]
    public void Consultation_should_be_open()
    {
        var c = new Consultations(Guid.NewGuid());
        Assert.True(c.Status == ConsultationStatus.Open);
    }

    [Fact]
    public void Consultation_should_not_have_ended_timestamp()
    {
        var c = new Consultations(Guid.NewGuid());
       Assert.Null(c.EndedAt);
    }

    [Fact]
    public void Consultation_should_not_end_when_missing_data()
    {
        var c = new Consultations(Guid.NewGuid());
        Assert.Throws<InvalidOperationException>(c.End);
    }

    [Fact]
    public void Consultation_should_end_with_complete_data()
    {
        var c = new Consultations(Guid.NewGuid());
        c.SetTreatment("Treatment") ; 
        c.SetDiagnosis("Diagnosis");
        c.SetWeight(18.5m);
        c.End();
        Assert.True(c.Status == ConsultationStatus.Closed);
    }

    [Fact]
    public void Consultation_should_not_allow_weight_updates_when_closed()
    {
        var c = new Consultations(Guid.NewGuid());
        c.SetTreatment("Treatment") ; 
        c.SetDiagnosis("Diagnosis");
        c.SetWeight(18.5m);
        c.End();
        Assert.Throws<InvalidOperationException>(() => c.SetWeight((19.2m)));
    }

}
