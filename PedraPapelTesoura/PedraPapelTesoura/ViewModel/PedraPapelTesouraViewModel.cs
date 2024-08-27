using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedraPapelTesoura.Models;

namespace PedraPapelTesoura.ViewModel
{
    public partial class PedraPapelTesouraViewModel : ObservableObject
    {
        [ObservableProperty]
        private string imagem;

        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string escolha;

        [ObservableProperty]
        private int pontuacaoJogador;

        [ObservableProperty]
        private int pontuacaoOponente;

        public void Jogar()
        {
            Jogador player = new Jogador();
            Jogador oponente = new Jogador();
            player.Jogar();

            if (Escolha == "pedra" && player.Sorteio == "tesoura" || Escolha == "papel" && player.Sorteio == "pedra" || Escolha == "tesoura" && player.Sorteio == "papel")
            {
                Resultado = "Você ganhou";
                player.Pontuacao ++;
            } else
            {
                Resultado = "Você perdeu";
                oponente.Pontuacao ++;
            }
        }
    }
}
