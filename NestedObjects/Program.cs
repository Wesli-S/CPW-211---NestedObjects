using NestedObjects;

Advisor compSciAdvisor = new Advisor()
{
    Email = "Annemarie@cptc.edu",
    FullName = "Annemarie Smith",
    OfficeLocation = "B17 Rm 150"
};

Student stu1 = new Student()
{
    FirstName = "Andrew",
    LastName = "Grace",
    DateOfBirth = new DateOnly(2001, 8, 26),//year, month, day
    StudentAdvisor = compSciAdvisor,
    PhoneNumber = "1234567890",
    SchoolEmail = "andrew.grace0826@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.StudentAdvisor.FullName} as their counselor");