using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace API_Folhas.Models
{
    public class FolhaPagamento
    {
        public FolhaPagamento() => CriadoEm = DateTime.Now;
        
        public int FolhaPagamentoId { get; set; }

        public float valorhora{ get; set; }

        public int FuncionarioId { get; set; }
        [ForeignKey("FuncionarioId")]
        
        public Funcionario funcionario { get; set; }
        public float quantidadehoras{ get; set; }
        public float impostorenda{ get; set;}
        public float impostoinss{ get; set; }
        public float salarioliquido{ get; set; }
        
        public float salariobruto
        {
        get
        {
            return valorhora * quantidadehoras;
        }
        }
        public DateTime CriadoEm { get; set; }
      
    }
}
