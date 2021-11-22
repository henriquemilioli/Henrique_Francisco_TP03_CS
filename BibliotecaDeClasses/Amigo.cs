using System;


namespace BibliotecaDeClasses
{
    public class Amigo
    {
        private string _nome;
        private string _sobrenome;
        private DateTime _dataDeNascimento;

        public Amigo(string Nome, string Sobrenome, DateTime DataDeNascimento)
        {
            _nome = Nome;
            _sobrenome = Sobrenome;
            _dataDeNascimento = DataDeNascimento;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }
        public DateTime DataDeNascimento
        {
            get { return _dataDeNascimento; }
            set { _dataDeNascimento = value; }
        }
    }

    

    
}
