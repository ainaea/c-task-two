namespace EmployeeTest
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal salary;  //Instance variable

        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        
        public decimal Salary
        {
            get { return salary; }
            private set { 
                if (value > 0.0M)
                {
                    salary = value;
                }
             }
        }

        public decimal Yearly()
        {
            return Salary * 12;
        }

        public string UpdateSalary(decimal newSalary)
        {
            Salary = newSalary;
            return $"{LastName} salary has been updated to {Salary}";
        }
    }
}