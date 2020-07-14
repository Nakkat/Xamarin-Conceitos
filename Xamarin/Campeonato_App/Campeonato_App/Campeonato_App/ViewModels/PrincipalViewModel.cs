using Campeonato_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato_App.ViewModels
{
    public class PrincipalViewModel
    {
        public List<Jogo> jogos { get; set; }

        public PrincipalViewModel()
        {
            jogos = new List<Jogo>
            {
                new Jogo
                {
                    id = 1,
                    estadio = "mineirão",
                    data  = DateTime.Now,
                    placarCasa = 7,
                    placarVisitante = 1,
                    penaltisCasa = 0,
                    penaltisVisitante = 0,
                    selecaoCasa = 1,
                    selecaoVisitante = 2
                },
                new Jogo
                {
                    id = 2,
                    estadio = "mineirão",
                    data  = DateTime.Now,
                    placarCasa = 6,
                    placarVisitante = 1,
                    penaltisCasa = 0,
                    penaltisVisitante = 0,
                    selecaoCasa = 1,
                    selecaoVisitante = 2
                }
            };
        }
    }
}
