//PENDİK BELEDİYESİNDE EĞİTİM VERİLİYOR ÖĞRENCİLER 480 SAAT EĞİTİM ALMAK ZORUNDALAR. BURADA ÖĞRENCİLERİN KİŞİSEL BİLGİLERİNİN TUTULDUĞU BİR SİSTEM İSTENİYOR. 

//İSTERLER : 
//•	Student adında bir class oluşturunuz
//•	StudentManager adında bir class oluşturunuz.

//Student:
//•	İsim, Soyisim, Yaş, Alan, Tuttuğu takım , bildikleri programlama dilleri, Numara, Yabancı Dil Biliyormu(bool), Semt


//•	ToString() kullanınız.
//•	Boş constructor ve dolu constructor oluşturunuz.



//StudentManager:
//•	Add(Student student);
//•	Update(Student student);
//•	Remove(Student student);

//Ekleme ve güncelleme işlemi yapılırken şu kurallar olmalıdır.
//•	Öğrenci adı ve Soyadı minimum 2 karakterli olmalıdır.
//•	Programlama dillerinden en az 1 tane bilmelidir.
//•	Öğrenci yaşı 35 den az 18 den büyük eşit olmalıdır.
//•	Numarası boş olmamalı ve +905 ile başlamalı
//•	Semt alanı boş olmamalı


//BAŞARILAR…

using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;
using System.Security;

Student student = new Student();


student.Name = "ahmet";
student.Surname = "boz";
student.Age = 19;
student.Alan = "web";
student.Takım = "fenerbahçe";
student.ProgramlamaDilleri = 1;
student.Numara = "905313";
student.YabancıDil = true;
student.Semt = "pendik";

Console.WriteLine(student.ToString());

student.EkranaYaz();

StudentManager studentManager = new StudentManager();
studentManager.Add(student);
studentManager.Update(student);
studentManager.Remove(student);




class Student
 {
    public Student()
    {
        
    }
    public Student(string name,string surname,int age,string alan, string takım, int programlamaDilleri, string numara, bool yabancıDil,string semt)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Alan = alan;
        Takım = takım;
        ProgramlamaDilleri = programlamaDilleri;
        Numara = numara;
        YabancıDil = yabancıDil;
        Semt = semt;

    }
    public string Name;
    public string Surname;
    public int Age;
    public string Alan;
    public string Takım;
    public int ProgramlamaDilleri;
    public string Numara;
    public bool YabancıDil;
    public string Semt;

    public void EkranaYaz()
    {
        Console.WriteLine($"öğrencininin ismi : {Name}");
        Console.WriteLine($"öğrencinin soyadı :{Surname} ");
        Console.WriteLine($"öğrencinin alanı :{Alan}");
        Console.WriteLine($"öğrencininin takımı :{Takım} ");
        
    }

    public override string ToString()
    {
        return $"Name : {Name}, Surname: {Surname}, Alan: {Alan}," +
            $"Takım : {Takım}, ProgramlamaDilleri: {ProgramlamaDilleri} Numara: {Numara} Yabancı dil: {YabancıDil}";
    }

}

class StudentManager
{
    public void Add(Student student)
    {
        if (student.Name.Length < 2)
        {
            Console.WriteLine("öğrencinin ismi 2 harften küçük olamaz");
            return;
        }

        if (student.Name.Length < 2)
        {
            Console.WriteLine("öğrencinin ismi 2 harften küçük olamaz");
            return;
        }
        if(student.ProgramlamaDilleri < 1)
        {
            Console.WriteLine("öğrenci en az bir tane programlama dili bilmeli");
            return;
        }
        if(student.Age>35 && student.Age <= 18)
        {
            Console.WriteLine("öğrencinin Yaşı 35 ten küçük 18 den büyük olmalı.");
            return;
        }
        if (string.IsNullOrEmpty(student.Numara) && !student.Numara.StartsWith("905"))
        {
            Console.WriteLine("numara boş olamaz ve 905 ile başlamalı");
            return;
        }
        if (string.IsNullOrEmpty(student.Semt))
        {
            Console.WriteLine("Semt bilgisi boş olamaz.");
            return;
        }


        Console.WriteLine("Öğrenci eklendi");
        student.EkranaYaz();
        // veri tabanına bağlan 
        // veriyi ekle 
        // hata yoksa olayları kaydet
        Console.WriteLine("************************************");
    }

    public void Remove(Student student)
    {
        Console.WriteLine("Öğrenci silindi");
        student.EkranaYaz();
        
        Console.WriteLine("************************************");
    }

    public void Update(Student student)
    {
        Console.WriteLine("Bilgisayar güncellendi.");
        student.EkranaYaz();
        
       
        Console.WriteLine("************************************");
    }
}
