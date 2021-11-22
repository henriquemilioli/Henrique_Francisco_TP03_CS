using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaDeClasses
{
    class BaseDeDados
    {
        public static List<Amigo> listaAmigos = new List<Amigo>();
        public static void SalvarAmigo(Amigo newAmigo)
        {
            listaAmigos.Add(newAmigo);
        }

        public static IEnumerable<Amigo> AmigosListados()
        {
            return listaAmigos;
        }
    }
}
