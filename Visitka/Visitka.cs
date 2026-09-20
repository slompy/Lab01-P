Console.WriteLine("===Визитная карточка студента===");

// Создадим переменные, в которые запишем информацию о студенте

string myName = "Даниил Потапов Сергеевич";
string myGroup = "ИСП-252";
int myCourseNumber = 2;
string myProfile = "Информационные системы и программирование";

// Создадим переменные, в которые запишем результаты студента

double myMathGrade = 4.5;
double myPhysicsGrade = 4.0;
double myChemistryGrade = 4.2;

// Проведём вычисления

double myAverageGrade = (myMathGrade + myPhysicsGrade + myChemistryGrade) / 3; // Вычисление среднего балла для студента
const double scholarshipthreshold = 4.0;
bool isScholarshipEligible = myAverageGrade >= scholarshipthreshold; // Вычисление стипендии студента

// Теперь выводим это в терминале пользователю

Console.WriteLine($"ФИО:            {myName}");
Console.WriteLine($"Группа:         {myGroup}");
Console.WriteLine($"Курс:           {myCourseNumber}");
Console.WriteLine($"Специальность:  {myProfile}");
Console.WriteLine($"Средний балл:   {myAverageGrade:F2}");
Console.WriteLine($"Стипендия положена (>= 4.0): {isScholarshipEligible}");   