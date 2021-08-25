using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {

        public readonly string _Nome;
        public Jogador1(string nome = "Daniel" )
        {
            _Nome = nome;
        }

        //chuta
        public string Chuta()
        {
           return $"{_Nome} está chutando \n";
        }
        //CORRE
        public string Corre()
        {
           return $"{_Nome} está correndo \n";
        }
        //Passe
        public string Passe()
        {
           return $"{_Nome} está passando \n";
        }
    }

}
