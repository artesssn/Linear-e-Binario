using System;

class Aluno
{
    
    public string Nome { get; set; }
    public string Matricula { get; set; }

    
    public Aluno(string nome, string matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }
}

class Program
{
  
    static Aluno BuscarAlunoPorMatricula(Aluno[] alunos, string matricula)
    {
        
        foreach (var aluno in alunos)
        {
            
            if (aluno.Matricula == matricula)
            {
                return aluno;  
            }
        }
        return null; 
    }

    static void Main(string[] args)
    {
       
        Aluno[] alunos = {
            new Aluno("João Silva", "202301"),
            new Aluno("Maria Oliveira", "202302"),
            new Aluno("Pedro Souza", "202303"),
            new Aluno("Ana Costa", "202304")
        };

        string matriculaParaBuscar = "202303";

      
        Aluno alunoEncontrado = BuscarAlunoPorMatricula(alunos, matriculaParaBuscar);

     
        if (alunoEncontrado != null)
        {
            Console.WriteLine($"Aluno encontrado: {alunoEncontrado.Nome}, Matrícula: {alunoEncontrado.Matricula}");
        }
        else
        {
            Console.WriteLine($"Aluno com matrícula {matriculaParaBuscar} não encontrado.");
        }
    }
}
