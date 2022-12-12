class Program
{

    static void Main()
    {
        Console.WriteLine("*****************");
        Console.Write("INPUT : ");
        Employee.NewEmployee();
    }    
}
public class Employee
{
    private static Dictionary<string, int> employeeList = new Dictionary<string, int>();

    public static void NewEmployee()
    {
        while (true)
        {
            string name = Input.GetString();
            
            if (employeeList.ContainsKey(name))
            {
                Console.WriteLine("*****************");
                Console.Write("OUTPUT : ");
                foreach (KeyValuePair<string, int> employee in employeeList)
                {
                    var emax = employeeList.Values.Max();
                    if (employee.Value == emax)
                    {
                        Console.WriteLine(employee.Key);
                    }
                }
               Console.WriteLine("*****************");
                return;
            }
            int count = Input.GetInt();
            employeeList.Add(name, count);
        }
    }
} 
public static class Input
{
    public static string GetString()
    {
        string s = Console.ReadLine();
        return s;
    }

    public static int GetInt()
    {
        string s = Console.ReadLine();
        if (int.TryParse(s, out int number))
        {
            return number;
        }

        return -1;
    }
}

