using PatikaWeek7PratikGroupJoin;
//Öğrenci ve sınıf liste tanımlamaları
List<Student> students = new List<Student>();
List<Classes> classes = new List<Classes>();
//Öğrenci sınıfından üretilen nesneler
Student student1 = new Student(1, "Ali", 1);
Student student2 = new Student(2, "Ayşe", 2);
Student student3 = new Student(3, "Mehmet", 1);
Student student4 = new Student(4, "Fatma", 3);
Student student5 = new Student(5, "Ahmet", 2);
//Üretilen nesnelerin listeye eklenmesi
students.Add(student1);
students.Add(student2);
students.Add(student3);
students.Add(student4);
students.Add(student5);
//Sınıflar sınıfından üretilen nesneler
Classes classes1 = new Classes(1, "Matematik");
Classes classes2 = new Classes(2, "Türkçe");
Classes classes3 = new Classes(3, "Kimya");
//Üretilen nesnelerin listeye eklenmesi
classes.Add(classes1);
classes.Add(classes2);
classes.Add(classes3);
//Grupjoin işleminin gerçekleşmesi ve listelerden istenilen parametlerin seçilmesi
var result = classes.GroupJoin(
           students, 
           cls => cls.ClassId, 
           student => student.ClassId, 
           (cls, studentsGroup) => new
           {
               ClassName = cls.ClassName, 
               Students = studentsGroup
           }
       );

// Sonuçları yazdırma
foreach (var item in result)
{
    Console.WriteLine($"Sınıf: {item.ClassName}");
    foreach (var student in item.Students)
    {
        Console.WriteLine($"  Öğrenci: {student.Name}");
    }
}