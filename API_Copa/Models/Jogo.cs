using System;
using API_Copa.Models;
using System.ComponentModel.DataAnnotations.Schema;//Add this component to foreign keys

namespace API_Copa.Models
{
    public class Jogo
    {
        public Jogo()
        {
            SelecaoA = new Selecao();
            SelecaoB = new Selecao();
            CriadoEm = DateTime.Now;
        }
        public int Id { get; set; }
        public int SelecaoAId {get; set;}
        public int SelecaoBId {get; set;}
        public Selecao SelecaoA { get; set; }
        public Selecao SelecaoB { get; set; }
        public int Placar { get; set; }
        public int Placar1 { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
