int[] scores = { 45, 90, 30, 75, 60, 20 };
int passingScore = 60;

int passedCount = 0;

foreach (int score in scores)
{
    if (score >= passingScore)
    {
        passedCount++;
    }
}

int[] passed = new int[passedCount];
int index = 0;

foreach (int score in scores)
{
    if (score >= passingScore)
    {
        passed[index] = score;
        index++;
    }
}

foreach (int score in passed)
{
    Console.WriteLine(score);
}

int failedCount = scores.Length - passedCount;

Console.WriteLine($"Не сдали экзамен: {failedCount}");

int[,] grades = {
    { 4, 5, 3 },
    { 5, 5, 4 },
    { 3, 4, 4 }
};

for (int subject = 0; subject < grades.GetLength(1); subject++)
{
    Console.WriteLine(grades[1, subject]);
}

int[,] grades = {
    { 4, 5, 3 },
    { 5, 5, 4 },
    { 3, 4, 4 }
};

double maxAverage = 0;
int bestStudent = 0;

for (int student = 0; student < grades.GetLength(0); student++)
{
    int sum = 0;

    for (int subject = 0; subject < grades.GetLength(1); subject++)
    {
        sum += grades[student, subject];
    }

    double average = (double)sum / grades.GetLength(1);

    Console.WriteLine($"Студент {student + 1}: средний балл {average}");

    if (average > maxAverage)
    {
        maxAverage = average;
        bestStudent = student;
    }
}

Console.WriteLine($"Наибольший средний балл у студента {bestStudent + 1}: {maxAverage}");

string[] subjects = {
    "Численные методы",
    "Архитектура аппаратных средств",
    "Физическая культура"
};

string[] backup = new string[subjects.Length];

Array.Copy(subjects, backup, subjects.Length);

subjects[0] = "Основы алгоритмизации и программирования";

Console.WriteLine("Исходный массив:");
foreach (string subject in subjects)
{
    Console.WriteLine(subject);
}

Console.WriteLine("Резервная копия:");
foreach (string subject in backup)
{
    Console.WriteLine(subject);
}

int[][] labsPerWeek = new int[3][];

labsPerWeek[0] = new int[] { 1, 2 };
labsPerWeek[1] = new int[] { 3, 4, 5 };
labsPerWeek[2] = new int[] { 6 };

for (int week = 0; week < labsPerWeek.Length; week++)
{
    Console.WriteLine($"Неделя {week + 1}: {labsPerWeek[week].Length} лабораторных работ");
}

int[] ages = { 16, 19, 21, 17, 18, 25, 15 };

int count = 0;

foreach (int age in ages)
{
    if (age > 18)
    {
        count++;
    }
}

int[] adults = new int[count];
int index = 0;

foreach (int age in ages)
{
    if (age > 18)
    {
        adults[index] = age;
        index++;
    }
}

Console.WriteLine("Возраст старше 18 лет:");

foreach (int age in adults)
{
    Console.WriteLine(age);
}

int[,] numbers = {
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 }
};

for (int row = 0; row < numbers.GetLength(0); row++)
{
    for (int column = 0; column < numbers.GetLength(1); column++)
    {
        Console.Write(numbers[row, column] + " ");
    }

    Console.WriteLine();
}

int[] ages = { 16, 19, 21, 17, 18, 25, 15 };

int count = 0;

foreach (int age in ages)
{
    if (age >= 18)
    {
        count++;
    }
}

int[] adults = new int[count];
int index = 0;

foreach (int age in ages)
{
    if (age >= 18)
    {
        adults[index] = age;
        index++;
    }
}

Console.WriteLine("Студенты от 18 лет:");

foreach (int age in adults)
{
    Console.WriteLine(age);
}

int[,] attendance = {
    { 1, 1, 0 },
    { 1, 0, 1 },
    { 0, 1, 1 },
    { 1, 1, 1 },
    { 0, 0, 1 }
};

for (int student = 0; student < attendance.GetLength(0); student++)
{
    for (int lesson = 0; lesson < attendance.GetLength(1); lesson++)
    {
        Console.Write(attendance[student, lesson] + " ");
    }

    Console.WriteLine();
}

int[,] grades = {
    { 5, 5, 5 },
    { 4, 5, 4 },
    { 5, 5, 4 },
    { 3, 4, 4 },
    { 5, 5, 5 }
};

string[] students = {
    "Анна",
    "Иван",
    "Мария",
    "Пётр",
    "Ольга"
};

double[] averages = new double[students.Length];

// Вычисление среднего балла каждого студента
for (int i = 0; i < students.Length; i++)
{
    int sum = 0;

    for (int subject = 0; subject < grades.GetLength(1); subject++)
    {
        sum += grades[i, subject];
    }

    averages[i] = (double)sum / grades.GetLength(1);

    Console.WriteLine($"{students[i]}: средний балл {averages[i]}");
}

// Подсчёт количества отличников
int count = 0;

foreach (double average in averages)
{
    if (average >= 4.5)
    {
        count++;
    }
}

// Создание массива отличников
string[] excellentStudents = new string[count];
int index = 0;

// Заполнение массива отличников
for (int i = 0; i < averages.Length; i++)
{
    if (averages[i] >= 4.5)
    {
        excellentStudents[index] = students[i];
        index++;
    }
}

// Вывод списка отличников
Console.WriteLine("Отличники:");

foreach (string student in excellentStudents)
{
    Console.WriteLine(student);
}