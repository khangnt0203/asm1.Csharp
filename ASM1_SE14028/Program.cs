using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1_SE14028
{
    class Program
    {
        public static List<SinhVien> list = new List<SinhVien>();

        static void Main(string[] args)
        {


            string Code;
            int input = 0;
            do
            {
                ReadLine();
                Clear();
                WriteLine("***Welcome to Student Manager Program***");
                WriteLine("1.List of Students");
                WriteLine("2.Add Student");
                WriteLine("3.Update Student by Code");
                WriteLine("4.Find Student by Code");
                WriteLine("5.Quit");
                Write("Choose:");
                input = Validation.CheckInput();

                switch (input)
                {
                    //Input List of Students
                    case 1:
                        WriteLine("***List of Students***");
                        foreach (SinhVien student in list)
                        {
                            WriteLine(student.XuatThongTin());
                        }
                        break;
                    //Add Student
                    case 2:
                        WriteLine("***Add Student***");
                        SinhVien sv = new SinhVien();
                        sv.NhapThongTin();
                        list.Add(sv);
                        break;
                    //Update Student
                    case 3:
                        WriteLine("***Update Student by Code***");
                        Write("Enter ID: ");
                        Code = ReadLine();
                        SinhVien UpdateSV = FindStuByCode(Code);
                        if (UpdateSV != null)
                        {
                            SinhVien NewStu = new SinhVien();
                            NewStu.NhapThongTin();
                            list.Remove(UpdateSV);
                            list.Add(NewStu);
                        }
                        else
                        {
                            WriteLine("Not Found!");
                        }

                        break;
                    //Find
                    case 4:
                        WriteLine("***Find Student by Code***");
                        Write("Enter ID: ");
                        Code = ReadLine();
                        SinhVien FindSV = FindStuByCode(Code);
                        if (FindSV != null)
                        {
                            WriteLine(FindSV.XuatThongTin());
                        }
                        else
                        {
                            WriteLine("Not Found!");
                        }
                        break;
                    case 5:
                        WriteLine("Goodbye");
                        break;

                    default:
                        WriteLine("Invalid Choice!");
                        break;
                }
            } while (input != 5);
        }

        public static SinhVien FindStuByCode(string code)
        {
            foreach (SinhVien Stu in list)
            {
                if ((Stu.MaSV).Equals(code))
                {
                    return Stu;
                }
            }
            return null;
        }
    }
}
