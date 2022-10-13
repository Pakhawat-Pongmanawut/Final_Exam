enum Menu {
    RegisterUStudent = 1,
    RegisterLecturer = 2 ,
    RegisterHStudent = 3 ,
    GetListPersons
}
class Program {

    static PersonList personList;

    public void PrintMenuScreen() {
        Console.Clear();

        PrintListMenu();
        InputMenuFromKeyboard();
    }

    public void PrintListMenu() {
        Console.WriteLine("Welcome to Idea camp 2022 registration ");
        Console.WriteLine("****************************************************");
        Console.WriteLine("1. Register to join");
        Console.WriteLine("2. Log-in");
        Console.WriteLine("3. Current participants is");
        Console.WriteLine("****************************************************");
    }

    static void InputMenuFromKeyboard() {
        Console.Write("Please input Menu : ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }

    static void PresentMenu(Menu menu) {
        switch (menu) {
            case Menu.RegisterUStudent:
                ShowInputRegistrationUStudentScreen();
                break;
            case Menu.RegisterHStudent:
                ShowInputRegistrationHStudentScreen();
                break;
             case Menu.RegisterLecturer:
                ShowInputRegistrationLecturerScreen();
                break;
            case Menu.GetListPersons:
                ShowPersons();
                break;
            default:
                break;
        }
    }

    static void ShowPersons() {
        Console.WriteLine("Show Persons");
        Console.WriteLine("************");

        Program.personList.FetchPersonList();
    }

    static void ShowInputRegistrationLecturerScreen() {
        Console.Clear();

        PrintHeaderRegistrationLecturer();

        // int totalLecturer = InputLecturerFromKeyboard();
        // InputLecturerFromKeyboard(totalLecturer);
    }

    static void ShowInputRegistrationUStudentScreen() {
        Console.Clear();

        PrintHeaderRegisterUStudent();

        int totalUStudent = TotalUStudent();
        InputNewStudentFromKeyboard(totalUStudent);
    }
    static void ShowInputRegistrationHStudentScreen() {
        Console.Clear();

        PrintHeaderRegisterHStudent();

        int totalHStudent = TotalHStudent();
        InputNewStudentFromKeyboard(totalHStudent);
    }

    static void PrintHeaderRegistrationLecturer() {
        Console.WriteLine("Register New Lecturer");
        Console.WriteLine("*********************");
    }

    static void PrintHeaderRegisterUStudent() {
        Console.WriteLine("Register New UStudent");
        Console.WriteLine("*********************");
    }
    static void PrintHeaderRegisterHStudent() {
        Console.WriteLine("Register New HStudent");
        Console.WriteLine("*********************");
    }

    static int TotalUStudent() {
        Console.Write("Input Total UStudent: ");

        return int.Parse(Console.ReadLine());
    }

    static int TotalHStudent() {
        Console.Write("Input Total HStudent: ");

        return int.Parse(Console.ReadLine());
    }
static int TotalLecturer() {
        Console.Write("Input Total Lecturer: ");

        return int.Parse(Console.ReadLine());
    }
    static void InputNewStudentFromKeyboard(int totalHStudent) {
        for(int i = 0; i < totalHStudent; i++) {
            Console.Clear();
            PrintHeaderRegisterHStudent();
            Console.Write("Please input your name title (Mr,Mrs,Miss) : ");
            string Inputnametitle = Console.ReadLine();
            Console.Write("Please input your name : ");
            string Inputname = Console.ReadLine();
            Console.Write("Please input your surname : ");
            string Inputsurname = Console.ReadLine(); 
            Console.Write("Please input your ages : ");
            double Inputages = double.Parse(Console.ReadLine());
            Console.Write("Please input your ID : ");
            string InputID = Console.ReadLine();
            Console.Write("Please input your religions : ");
            string Inputreligions = Console.ReadLine();
            Console.Write("Please input your allergy : ");
            string Inputallergy = Console.ReadLine();
             Console.Write("Please input your school name : ");
            string InputSchoolname = Console.ReadLine();
            
            HStudent student = new HStudent(Inputnametitle,
            Inputname, Inputsurname, 
            Inputages, InputID, 
            Inputreligions, Inputallergy , InputSchoolname);
            Console.WriteLine(student.ToString());
            List<HStudent> HighschoolList = new List<HStudent>();
            HighschoolList.Add(student);
        }
    
    static void BackToMainMenu() {
        Console.Clear();
        Program temp = new Program();
        temp.PrintListMenu();
        InputMenuFromKeyboard();
    }
static void InputNewStudentFromKeyboard(int totalUStudent) {
        for(int i = 0; i < totalUStudent; i++) {
            Console.Clear();
            PrintHeaderRegisterHStudent();
            Console.Write("Please input your name title (Mr,Mrs,Miss) : ");
            string Inputnametitle = Console.ReadLine();
            Console.Write("Please input your name : ");
            string Inputname = Console.ReadLine();
            Console.Write("Please input your surname : ");
            string Inputsurname = Console.ReadLine(); 
            Console.Write("Please input your ages : ");
            double Inputages = double.Parse(Console.ReadLine());
            Console.Write("Please input your ID : ");
            string InputID = Console.ReadLine();
            Console.Write("Please input your religions : ");
            string Inputreligions = Console.ReadLine();
            Console.Write("Please input your allergy : ");
            string Inputallergy = Console.ReadLine();
            
            UStudent student = new UStudent(Inputnametitle,
            Inputname, Inputsurname, 
            Inputages, InputID, 
            Inputreligions, Inputallergy);
        }
        static void BackToMainMenu() {
        Console.Clear();
        Program temp = new Program();
        temp.PrintListMenu();
        InputMenuFromKeyboard();
        }
    

 static void InputLecturerFromKeyboard(int totalLecturer) {
        for(int i = 0; i < totalLecturer; i++) {
            Console.Clear();
            PrintHeaderRegisterHStudent();
            Console.Write("Please input your name title (Mr,Mrs,Miss) : ");
            string Inputnametitle = Console.ReadLine();
            Console.Write("Please input your name : ");
            string Inputname = Console.ReadLine();
            Console.Write("Please input your surname : ");
            string Inputsurname = Console.ReadLine(); 
            Console.Write("Please input your ages : ");
            double Inputages = double.Parse(Console.ReadLine());
            Console.Write("Please input your ID : ");
            string InputID = Console.ReadLine();
            Console.Write("Please input your religions : ");
            string Inputreligions = Console.ReadLine();
            Console.Write("Please input your allergy : ");
            string Inputallergy = Console.ReadLine();
        
            Lecturer lecturer = new Lecturer(Inputnametitle,
            Inputname, Inputsurname, 
            Inputages, InputID, 
            Inputreligions, Inputallergy);
        }

    static void BackToMainMenu() {
        Console.Clear();
        Program temp = new Program();
        temp.PrintListMenu();
        InputMenuFromKeyboard();
    }
}

}
    }
}