// string myName = "Даниил";
// string myGroupName = "ИСП-252";
// int myCourseNumber = 2;
// double myavarageGrade = 4.5;
// bool isIStudent = true;

// // Console.WriteLine($"Студент: {myName}");
// // Console.WriteLine($"Группа: {myGroupName}");
// // Console.WriteLine($"Курс: {myCourseNumber}");
// // Console.WriteLine($"Средний балл: {myavarageGrade}");
// // Console.WriteLine($"Студент ли я: {isIStudent}");

// Console.WriteLine($"Студент: {myName}, Группа: {myGroupName} Курс: {myCourseNumber} Средний балл: {myavarageGrade} Студент ли я: {isIStudent}");Console.WriteLine("Hello, World!");

// Console.WriteLine("Ремонт комнаты"); // Наша задача
// double roomWidht = 3.5;
// double roomLenght = 4.2;
// double roomArea = roomWidht * roomLenght;
// double roomPerimeter = (roomWidht + roomLenght) * 2; // Поиск периметра
// /*
// Теперь вывожу в консоль
// */
// Console.WriteLine($"Ширина комнаты: {roomWidht}");
// Console.WriteLine($"Длина комнаты: {roomLenght}");
// Console.WriteLine($"Площадь комнаты: {roomArea}");
// Console.WriteLine($"Периметр комнаты: {roomPerimeter}");


// string firstName = "Даниил";
// string lastName = "Потапов";

// string fullNameConcat = firstName + " " + lastName;

// string fullNameInterp = $"{firstName} {lastName}";

// string fullNameConcatMethod = string.Concat(firstName, " ", lastName);

// Console.WriteLine(fullNameConcat);
// Console.WriteLine(fullNameInterp);
// Console.WriteLine(fullNameConcatMethod);



//  Console.WriteLine("Покупка ноутбука в рассрочку");
//  int laptopPrice = 65000;
//  int monthsCount = 12;
//  double interestRate = 0.08;
//  double totalWithInterest = laptopPrice * (1 + interestRate);
//  double monthlyPayment = totalWithInterest / monthsCount;
// /*
//     Теперь начинаем 
//      Выводить:
// */

//  Console.WriteLine($"Цена ноутбука: {laptopPrice} руб."); // Вывод цены ноутбука для пользователя
//  Console.WriteLine($"Итого с процентами: {totalWithInterest} руб."); // Вывод с процентами для пользователя
//  Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб."); // Вывод платежа в месяц для пользователя

// Console.WriteLine("Внимание: деление int");

// int totalStudents = 25;
// int groupsCount = 4;

// int studentsPerGroupWrong = totalStudents / groupsCount;
// double studentsPerGroupCorrect = (double)totalStudents / groupsCount;

// Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
// Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");

// Console.WriteLine("Константы");

// const double VatRate = 0.2;
// const string CollegeName = "ВФ ВолГУ";

// double productPrice = 1000;
// double priceWithVat = productPrice * (1 + VatRate);

// Console.WriteLine($"Учебное заведение: {CollegeName}");
// Console.WriteLine($"Цена без НДС: {productPrice}, c НДС ({VatRate:P0}):{priceWithVat}");

// // Задание 1.
// int scholarship = 1200;
// int monthlyExpenses = 4000;
// const int MonthsInSemester = 4;

// int monthResult = scholarship - monthlyExpenses;
// Console.WriteLine($"К концу месяца останется: {monthResult}");
// int semestrMonthsResult = monthResult * MonthsInSemester;
// Console.WriteLine($"К концу семестра останется: {semestrMonthsResult}");

// Задание 3.
int totalMinutes = 300;
int minutesPerLesson = 45;

int lessonsCount = totalMinutes / minutesPerLesson;

int andMinutes =  totalMinutes % minutesPerLesson;

Console.WriteLine($"{totalMinutes} минут = {lessonsCount} полных занятий + {andMinutes} минут.");