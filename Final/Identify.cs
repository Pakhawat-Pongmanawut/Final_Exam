public class Identify {
  private string nametitle ;
  private string name ;
  private string surname ;
  private double ages ;
  private string ID;
  private string religions;
  private string allergy;

  public Identify(string nametitle,
                string name,
                string surname,
                double ages,
                string religions,
                string ID,
                string allergy){
                    this.nametitle = nametitle;
                    this.name = name;
                    this.surname = surname;
                    this.ages = ages;
                    this.ID = ID;
                    this.religions = religions;
                    this.allergy = allergy;
                }
    public string GetNameTitle()
    {
        return this.nametitle;
    }

    public string GetName()
    {
        return this.name;
    }
    public string GetSurname()
    {
        return this.surname;
    }
    public double GetAges()
    {
        return this.ages;
    }
    public string GetID()
    {
        return this.ID;
    }
     public string GetReligion()
    {
        return this.religions;
    }

    public string GetAllergy()
    {
        return this.allergy;
    }
}