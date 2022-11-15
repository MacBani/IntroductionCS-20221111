//4. По заданному с клавиатуры номеру дня недели вывести его название
List<string> Weekday = new List<string>(){"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
System.Console.WriteLine("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(Weekday[number-1]);
