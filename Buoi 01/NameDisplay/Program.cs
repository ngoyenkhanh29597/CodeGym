//Khai báo biến lưu trữ dữ liệu
string name;
int birthyear;
//Nhập dữ liệu
Console.Write("What's your name? ");
name = Console.ReadLine();
Console.WriteLine("What's your birthyear? ");
birthyear = int.Parse(Console.Read());
//Tính tuổi dựa vào năm sinh
int age = DateTime.Now.Year - birthyear;
Console.WriteLine("Hello: " + name + ", your age is " + age );
//C# bắt đầu là STRING kết thúc là STRING (toString())