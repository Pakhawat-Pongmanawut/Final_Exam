//HStudent = Highschool Student
public class HStudent: Identify {
    private string Hstudent;
  private string Schoolname;
    public HStudent(string nametitle,
                string name,
                string surname,
                double ages,
                string ID,
                string religions,
                string allergy,
                string Schoolname)
    : base(nametitle, name, surname, ages, ID, religions, allergy) {
        this.Hstudent = Hstudent;
        this.Schoolname = Schoolname;
    }
    public string GetSchoolname()
    {
        return this.Schoolname;
    }
    public bool ToString()
    {
        Console.WriteLine(GetNameTitle()+" "+GetName()+" "+GetSurname()
        +" "+GetAges()+" "+GetID()+" "+GetReligion()+" "+GetAllergy()+" "+GetSchoolname());
        return true;
    }
}
