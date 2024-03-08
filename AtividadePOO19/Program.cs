using AtividadePOO19.Entities;

namespace AtividadePOO19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> ConjuntoA = new HashSet<int>();
            HashSet<int> ConjuntoB = new HashSet<int>();
            HashSet<int> ConjuntoC = new HashSet<int>();

            Console.Write("How many students for course A?  ");
            int CourseA = int.Parse(Console.ReadLine());

            for (int i = 0; i < CourseA; i++)
            {
                Console.Write($"Aluno {i + 1}: ");

                int aux = int.Parse(Console.ReadLine());

                ConjuntoA.Add(aux);
            }

            Console.Write("How many students for course B?  ");
            int CourseB = int.Parse(Console.ReadLine());

            for (int i = 0; i < CourseB; i++)
            {
                Console.Write($"Aluno {i + 1}: ");

                int aux = int.Parse(Console.ReadLine());

                ConjuntoB.Add(aux);
            }

            Console.Write("How many students for course C?  ");
            int CourseC = int.Parse(Console.ReadLine());

            for (int i = 0; i < CourseC; i++)
            {
                Console.Write($"Aluno {i + 1}: ");

                int aux = int.Parse(Console.ReadLine());

                ConjuntoC.Add(aux);
            }

            Students Estudantes = new Students(ConjuntoA, ConjuntoB, ConjuntoC);

            Console.WriteLine($"Total de alunos: {Estudantes.TotalAlunos()}");
        }
    }
}
