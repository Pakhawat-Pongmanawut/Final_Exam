//Lecturer = อาจารย์
public class Lecturer: Identify {
    private string Lecturers;

    public Lecturer(string nametitle,
                string name,
                string surname,
                double ages,
                string ID,
                string religions,
                string allergy)
    : base(nametitle, name, surname, ages, ID, religions, allergy) {
        this.Lecturers = Lecturers;
    }
    
    public class LecturerRank{
    private string Vacancy;
    public LecturerRank(string Vacancy)
    {
        this.Vacancy = Vacancy;
    }
    public string GetVacancy()
    {
        return this.Vacancy;
    }

 public class Vehicle{
    private string CarLicence;
    public Vehicle(string CarLicence)
    {
        this.CarLicence = CarLicence;
    }
    public string GetLicence()
    {
        return this.CarLicence;
    }
 }
}
}