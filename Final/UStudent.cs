//UStudent = University Student
public class UStudent: Identify {
    private string Ustudent;

    public UStudent(string nametitle,
                string name,
                string surname,
                double ages,
                string ID,
                string religions,
                string allergy)
    : base(nametitle, name, surname, ages, ID, religions, allergy) {
        this.Ustudent = Ustudent;
    }
}