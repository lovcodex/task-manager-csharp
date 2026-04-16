using System;
using System.Collections.Generic;
using System.Text;

namespace task_manager_csharp
{
    public class Tarefa
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public enum StatusTarefa
        {
            Pendente,
            EmProgresso,
            Concluida
        }

        public StatusTarefa Status { get; set; }

        public int Prioridade { get; set; }

        public void AlterarStatus(StatusTarefa novoStatus)
        {
            Status = novoStatus;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Status} - Prioridade: {Prioridade}";
        }
    }
}