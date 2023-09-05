using System;

namespace QuizApp
{
    class Program
    {
        static Random rand = new Random();

        static string[][] questions = new string[6][];
        static string[] correctAnswers = new string[6];
        static int userScore = 0;

        static void InitializeQuestions()
        {
            questions[0] = new string[] { "Bağçasının paytaxtı hansı şəhərdir?", "a) Bakı", "b) Gəncə", "c) Naxçıvan" };
            questions[1] = new string[] { "Dünyada ən uzun dəniz kənarı olan ölkə hansıdır?", "a) Kanada", "b) Rusiya", "c) Avstraliya" };
            questions[2] = new string[] { "2023 uncu ilde hansi olkede uefa Final kecirilib ? ", " a)Turkiye b)Azerbaycan c)Naxcivan " };
            questions[3] = new string[] { "Dəfn mərasiminizdə insanlar sizin haqqınızda nə danışacaqlar? ", " a)he b)yox  c)saxtalardan uzagam" };
            questions[4] = new string[] { "Neye gore Proqrasdilma sahesi?", "a) Elmi Ve pulu qazanmaq ucun ", "b) Nenenin telefonu nu duzeldende menden fexr etmesi ucun", "c) Qizlara ozunu gostermek ucun" };
            questions[5] = new string[] { "Kisiler Qadinlardan Niye az yasayir", "a) Qadinlar daha cox xeyanet etdiyine gore", "b) Kisiler yasamir surunur", "c) Cavab B " };
            



            correctAnswers[0] = "a";
            correctAnswers[1] = "c";
            correctAnswers[2] = " a";
            correctAnswers[3] = "c";
            correctAnswers[4] = "c";
            correctAnswers[5] = "c ";
           
        }

        static void ShuffleAnswers(string[] answers)
        {
            for (int i = 0; i < answers.Length; i++)
            {
                int randomIndex = rand.Next(i, answers.Length);
                string temp = answers[i];
                answers[i] = answers[randomIndex];
                answers[randomIndex] = temp;
            }
        }

        static void Main(string[] args)
        {
            InitializeQuestions();

            Console.WriteLine("Imtahan basladi. Cavablar a), b), c) formatinda secin.");

            for (int i = 0; i < questions.Length; i++)
            {
                string[] question = questions[i];
                ShuffleAnswers(question); 

                Console.WriteLine($"{i + 1}. {question[0]}");
                Console.WriteLine(question[1]);
                Console.WriteLine(question[2]);
                Console.WriteLine(question[3]);

                string userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == correctAnswers[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Dogru cavab!\n");
                    userScore += 10;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sehv cavab! Dogru cavab: {correctAnswers[i]}\n");
                }
                Console.ResetColor();
            }

            Console.WriteLine($"Imtahan bitdi. Sizin xaliniz: {Math.Max(userScore, 0)}");
        }
    }
}
