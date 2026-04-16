using task_manager_csharp;

var tarefa = new Tarefa
{
    Titulo = "Estudar POO",
    Descricao = "Aprender classes e objetos",
    Status = Tarefa.StatusTarefa.Pendente,
    Prioridade = 1
};

Console.WriteLine(tarefa);

tarefa.AlterarStatus(Tarefa.StatusTarefa.EmProgresso);

Console.WriteLine(tarefa);