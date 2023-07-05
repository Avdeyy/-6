// See https://aka.ms/new-console-template for more information
using Практическая__6;

Person Igor = new Person();Igor.Name = "Игорь";Igor.Age = 20;Igor.PersonSpeciality = (Speciality)1;Igor.Score = 2.7;
Person Igor2 = new Person();Igor2.Name = "Иван";Igor2.Age = 22;Igor2.PersonSpeciality = (Speciality)2;Igor2.Score = 5.0;
Person Igor3 = new Person();Igor3.Name = "Денис";Igor3.Age = 23;Igor3.PersonSpeciality = (Speciality)3;Igor3.Score = 4.2;
Person Igor4 = new Person();Igor4.Name = "Аркадий";Igor4.Age = 19;Igor4.PersonSpeciality = (Speciality)2;Igor4.Score = 4.4;
Person Igor5 = new Person();Igor5.Name = "Михаил";Igor5.Age = 25;Igor5.PersonSpeciality = (Speciality)0;Igor5.Score = 4.7;
Person Igor6 = new Person();Igor6.Name = "Олег";Igor6.Age = 25;Igor6.PersonSpeciality = (Speciality)4;Igor6.Score = 3.7;
Person Igor7 = new Person();Igor7.Name = "Виталий";Igor7.Age = 23;Igor7.PersonSpeciality = (Speciality)0;Igor7.Score = 4.5;
Person Igor8 = new Person();Igor8.Name = "Евдоким";Igor8.Age = 24;Igor8.PersonSpeciality = (Speciality)1;Igor8.Score = 4.1;
Person Igor9 = new Person();Igor9.Name = "Владислав";Igor9.Age = 25;Igor9.PersonSpeciality = (Speciality)2;Igor9.Score = 3.9;
Person Igor10 = new Person();Igor10.Name = "Евгений";Igor10.Age = 24;Igor10.PersonSpeciality = (Speciality)3;Igor10.Score = 4.8;

Factory Candid = new Factory();
Candid.Candidates.Add(Igor);
Candid.Candidates.Add(Igor2);
Candid.Candidates.Add(Igor3);
Candid.Candidates.Add(Igor4);
Candid.Candidates.Add(Igor5);
Candid.Candidates.Add(Igor6);
Candid.Candidates.Add(Igor7);
Candid.Candidates.Add(Igor8);
Candid.Candidates.Add(Igor9);
Candid.Candidates.Add(Igor10);

Department Dept = new Department();
Dept.StaffSelection(Candid.Candidates);

ElectricianDepartment Elect = new ElectricianDepartment();
Elect.Title = "энергетическое подразделение";
Elect.StaffSelection(Dept.Employees);

MechanicDepartment Mech = new MechanicDepartment();
Mech.Title = "ремонтно-механическое подразделение";
Mech.StaffSelection(Dept.Employees);

InformDepartment Inf = new InformDepartment();
Inf.Title = "диспетчерское подразделение";
Inf.StaffSelection(Dept.Employees);

Factory Depart = new Factory();
Depart.Departments.Add(Elect);
Depart.Departments.Add(Mech);
Depart.Departments.Add(Inf);


Console.WriteLine(Elect.PrintEmployees());
Console.WriteLine(Mech.PrintEmployees());
Console.WriteLine(Inf.PrintEmployees());

//Inf.PrintEmployees();