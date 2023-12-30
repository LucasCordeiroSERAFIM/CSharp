using OrientecaoObjeto;
using System;
namespace ProjetoPOO
{
    public class Program{
    public static void Main(string[] args){

     Leao leao = new Leao();
    leao.nome = "Leoneto";
    leao.peso = 150.50;
    leao.cor = "Rosa";
    leao.SeMover();
    leao.Rugir();
    leao.SeAlimenta();
            // metodos da interface
            leao.Mamar();
            leao.ComerCarne();



     Louro louro = new Louro();
    louro.nome = "Bat Mirim";
    louro.cor = "Pretinho";
    louro.peso = 0.500;
    louro.SeMover();
    louro.Falar();
    louro.SeAlimenta();

            // metodos da interface
            louro.Voar();
            louro.ComerFruta();
        }
    }
    
    
}