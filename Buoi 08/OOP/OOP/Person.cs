using System;
namespace OOP
{
	public class Person
	{
		public string name;
		public int yearofBirth;
		public int sex;

		//Hàm khởi tạo mặc định
		//B1 Chọn hàm có nhiều tham số
		//B2 Sắp xếp thư tự ưu tiên các tham số
		//B3 Đặt giá trị mặc định cho tham (giảm tải tham số từ phải sang trái ) 
		
        public Person(string name = "Ngo Yen Khanh", int yearofBirth = 1997, int sex = 1)
        {
            this.name = name;
            this.yearofBirth = yearofBirth;
            this.sex = sex;
        }

        public void print()
		{
			if (sex == 1) Console.Write("Mr. ");
			else Console.Write("Ms. ");
			Console.WriteLine(name + " was born in " + yearofBirth);
		}
		
	}
}

