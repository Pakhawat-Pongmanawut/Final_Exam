//PersonList = UStudent + HStudent + Lecturer
class PersonList {
    private List<Identify> personList;
    private List<HStudent> HighschoolList;
    
    public PersonList() {
        this.personList = new List<Identify>();
        this.HighschoolList = new List<HStudent>();
    }

    public void AddNewPerson(Identify identify) {
        this.personList.Add(identify);
    }
    public void AddNewHighschool(HStudent Hstudent) {
        Console.WriteLine(Hstudent.ToString());
        this.HighschoolList.Add(Hstudent);
    }

    public void FetchPersonList() {
        Console.WriteLine("List Person Identify");
        Console.WriteLine("********************");

        foreach(Identify identify in this.personList) {
            if (identify is UStudent) 
            {
                Console.WriteLine("Nametitle : {0}",identify.GetNameTitle());
                Console.WriteLine("Name : {0}",identify.GetName());
                Console.WriteLine("Surname : {0}",identify.GetSurname());
                
            } 
            else if (identify is HStudent) 
            {
                Console.WriteLine("Nametitle : {0}",identify.GetNameTitle());
                Console.WriteLine("Name : {0}",identify.GetName());
                Console.WriteLine("Surname : {0}",identify.GetSurname());
               
            }
           else if (identify is Lecturer) 
           {
                Console.WriteLine("Nametitle {0}",identify.GetNameTitle());
                Console.WriteLine("Name : {0}",identify.GetName());
                Console.WriteLine("Surname : {0}",identify.GetSurname());
           }
    }
}
}