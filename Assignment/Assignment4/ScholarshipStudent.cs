class ScholarshipStudent : Student
{
    public ScholarshipStudent(int id, string name, string dept)
        : base(id, name, dept)
    {
    }

    public override double CalculateFee()
    {
        return TotalCredits() * 500;
    }
}