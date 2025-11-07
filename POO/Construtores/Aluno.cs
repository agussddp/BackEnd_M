// Classe Aluno:
// Crie uma classe Aluno com atributos nome e nota.
// Crie dois construtores: um sem parâmetros (define valores padrão) e outro que receba nome e nota.
// Mostre os dados dos alunos criados.
public class Aluno
    {
        public string Nome;

        public float Nota;

        public Aluno()
        {
            Console.WriteLine($"Aluno criado!");
            
        }

        public Aluno(string n, float No)
        {
            Nome = n;
            Nota = No;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"O nome do aluno é {Nome} e a nota é {Nota}");
            
        }
    }