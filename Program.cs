namespace Labb8_OOP_Generci_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create 5 employees
            Employee employee1 = new Employee(1, "Adam", Gender.Male, 20000);
            Employee employee2 = new Employee(2, "Berit", Gender.Female, 21000);
            Employee employee3 = new Employee(3, "Cesar", Gender.Male, 21500);
            Employee employee4 = new Employee(4, "David", Gender.Male, 19000);
            Employee employee5 = new Employee(5, "Erika", Gender.Female, 25000);


            //Create stack and push employees to stack
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);


            PrintForeach(stack);
            PrintPop(stack);

            //Refill stack after pop
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            PrintPeek(stack);

            IsEmployeeInStack(employee3, stack);

            //Create List and add Employees
            List<Employee> list = new List<Employee>();
            list.Add(employee1);
            list.Add(employee2);
            list.Add(employee3);
            list.Add(employee4);
            list.Add(employee5);


            IsEmployeeInList(employee2, list);

            PrintFirstMale(list);

            PrintAllMale(list);
        }

        //Finds all employees with gender = male and adds them to a list and prints info
        private static void PrintAllMale(List<Employee> list)
        {
            Console.WriteLine();
            Console.WriteLine("--------All Male in list--------");
            var allMale = list.FindAll(x => x.Gender == Gender.Male);

            foreach (Employee emp in allMale)
            {
                emp.PrintInfo();
            }
        }

        //Finds the first employee with gender =  male and print info
        private static void PrintFirstMale(List<Employee> list)
        {
            Console.WriteLine();
            Console.WriteLine("--------First Male in list--------");
            var tempMale = list.Find(x => x.Gender == Gender.Male);

            tempMale.PrintInfo();
        }

        //Look if list contains employee2
        private static void IsEmployeeInList(Employee employee2, List<Employee> list)
        {
            Console.WriteLine();
            Console.WriteLine("--------Is Employee2 in list--------");
            if (list.Contains(employee2))
            {
                Console.WriteLine("Employee2 exists in the list");
            }
        }

        //Look if stack contains employee3
        private static void IsEmployeeInStack(Employee employee3, Stack<Employee> stack)
        {
            Console.WriteLine();
            Console.WriteLine("--------Is Employee3 in stack--------");

            if (stack.Contains(employee3))
            {
                Console.WriteLine(" employee 3 is in stack");
            }
            else
            {
                Console.WriteLine(" employee 3 is not in stack");
            }
        }

        //Peek on first in stack and print two times
        private static void PrintPeek(Stack<Employee> stack)
        {
            Console.WriteLine();
            Console.WriteLine("--------Peek--------");
            var temp1 = stack.Peek();
            var temp2 = stack.Peek();

            temp1.PrintInfo();
            temp2.PrintInfo();
        }

        //Loop to get print information poping Employees from stack
        private static void PrintPop(Stack<Employee> stack)
        {
            Console.WriteLine();
            Console.WriteLine("--------POP--------");
            for (int i = stack.Count(); i > 0; i--)
            {
                var temp = stack.Pop();
                temp.PrintInfo();
                Console.WriteLine($"There is {stack.Count()} Employees left to print");
            }
        }

        //Foreach to print information about Employees
        private static void PrintForeach(Stack<Employee> stack)
        {
            Console.WriteLine("--------Foreach--------");
            foreach (Employee emp in stack)
            {
                emp.PrintInfo();
                Console.WriteLine($"There is {stack.Count()} Employees left to print");
            }
        }
    }
}