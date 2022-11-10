using System;

namespace Ex28_template
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(10, 19, 100, DateTime.Today, "SH", 50, 150, 30, 50);
            Console.WriteLine($"名前{student.Name} 年齢{student.Age} 誕生日{student.BirthDay.Date} 今日は誕生日か({student.GetTodayBirthDay()}) 学籍番号{student.StudentNumber}");
            Worker worker = new Worker("TUTAYA", 35, 100, DateTime.Today, "SY", 50, 100, 30, 50);
            Console.WriteLine($"名前{worker.Name} 年齢{worker.Age} 誕生日{worker.BirthDay.Date} 会社名{worker.CompanyName}");
            Fish fish = new Fish(true, DateTime.Today, "アロワナ", 85, 50, 11, 10);
            Console.WriteLine($"名前{fish.Name} 重さ{fish.Weight} 食べられるか({fish.Eatable})体長{fish.Height}");
            Refrigerator refrigerator = new Refrigerator(900, 300, 80, 200, 100, "冷蔵庫「ＺＩＰＥＬ Ｔ９０００」", 70, 190, 90, 200);
            Console.WriteLine($"名前{refrigerator.Name} 重さ{refrigerator.Weight} 容量{refrigerator.Capacity}L");
            Insect insenct = new Insect(false, DateTime.Today, "カマドウマ", 19, 2, 1, 0.5f);
            Console.WriteLine($"名前{insenct.Name} 飛行能力の有無{insenct.Flyable}体長{insenct.Height}");
            Car car = new Car(4, "カウンタック", 414, 107, 189, 1200);
            Console.WriteLine($"名前{car.Name} 燃費{car.FuelConsumption}全長{car.Width}");
            Cat cat = new Cat("キジトラ", DateTime.Today, "猫", 30, 30, 4, 20);
            Console.WriteLine($"名前{cat.Name} 猫種{cat.CatType}体重{cat.Weight}");
            Apexguns apexguns = new Apexguns(27, "R-99", 45, 45, 189, 1200);
            Console.WriteLine($"名前{apexguns.Name} 装弾数{apexguns.AmmunitionCapacity}口径{apexguns.Width}有効射程{apexguns.Height}");
        }
    }
}
