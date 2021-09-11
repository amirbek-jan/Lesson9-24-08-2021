using System;

// Первое ДЗ
class Converter {
    double rubVal = 0.15;
    double usdVal = 11.32;
    double eurVal = 13.39;
    
    public double Usd { get; set; }
    public double Eur { get; set; }
    public double Rub { get; set; }

    // Сом ба дигар
    public double SomToRub(double som) {
        return som / rubVal;
    }

    public double SomToUsd(double som) {
        return som / usdVal;
    }

    public double SomToEur(double som) {
        return som / eurVal;
    }


    // дигар ба сом
    public double RubToSom(double rubVal) {
        return Rub * rubVal;
    }

    public double UsdToSom(double usdVal) {
        return Usd * usdVal;
    }

    public double EurToSom(double eurVal) {
        return Eur * eurVal;
    }

    public Converter(double rub, double usd, double eur) {
        Rub = rub;
        Usd = usd;
        Eur = eur;
    }
}
   class Program {
    static void Main() {
        double rubVal = 0.15;
        double usdVal = 11.32;
        double eurVal = 13.39;

        Converter con = new Converter(usdVal, eurVal, rubVal);

        
        while (true) {
            Console.Write("Convert to somoni or from somoni ? {to, from}: "); string type = Console.ReadLine();

            Console.Write($"Input amount: ");   double val = double.Parse(Console.ReadLine());

            double res = 0; 
            string fx = "";
            Console.Write("Convert to what ? {usd, eur, rub, som}: "); string сurr = Console.ReadLine();

            if (type == "to") {
                fx = сurr;
                if (сurr == "usd") res = con.SomToUsd(val);
                else if (сurr == "eur") res = con.SomToEur(val);
                else if (сurr == "rub") res = con.SomToRub(val);
                else Console.WriteLine($"{"Warn"}");
            } else {
                fx = "Som";
                if (сurr == "eur") res = con.UsdToSom(val);
                else if (сurr == "rub") res = con.EurToSom(val);
                else if (сurr == "usd") res = con.RubToSom(val);
                else Console.WriteLine($"{"Warn"}");
            }
            Console.WriteLine($"Result: {res}{fx}");
        }
    }
}

// Второе ДЗ
class Employee {
    public string Surname { get; set; }
    public string Name { get; set; }

    public string Position { get; set; }
    public double Salary { get; set; }

    public double GetTax() {
        return Salary * (13.0 + 1.0) / 100.0;
    }

    public void GetInfo() {
        Console.WriteLine($"Фамилия: {Surname}\nИмя: {Name}\nДолжность: {Position}\nЗП: {Salary}\nНалог: {GetTax()}");
    }

    public Employee(string surname, string name) {
        Surname = surname;
        Name = name;
    }
}
class Program {

    static void Main() {
        Console.Write("Фамилия: "); string surname = Console.ReadLine();
        Console.Write("Имя: "); string name = Console.ReadLine();

        Console.Write("Должность: "); string posit = Console.ReadLine();
        Console.Write("ЗП в месяц: "); double sal = double.Parse(Console.ReadLine());

        Employee me = new Employee(surname, name);

        me.Position = posit;
        me.Salary = sal;

        me.GetInfo();
    }

}