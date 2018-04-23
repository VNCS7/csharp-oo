using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HerancaAnimais
{
    class Cachorro : Mamifero
    {
        public override void locomover()
        {
            Console.WriteLine("Cachorro se locomovendo"); ;
        }
        public override void alimentar()
        {
            Console.WriteLine("Cachorro se Alimentando!");
        }
        public override void emitirSom()
        {
            Console.WriteLine("Cachorro latindo!");
        }

        public void enterrarOsso()
        {
            Console.WriteLine("Cachorro enterrando o osso!");
        }

        public void abanarRabo()
        {
            Console.WriteLine("Cachorro abanando o rabo!");
        }

        public string reagir(string atitude)
        {
            if (atitude == "brincar" || atitude == "acariciar")
                return "Cachorro abanando o rabo - reação";
            else
                return "Cahorro rosnando";

        }

        public void reagir(int hora)
        {
            if (hora < 12)
                Console.WriteLine("Cachorro abanando o rabo e latindo");
            else if (hora >= 18)
                Console.WriteLine("Cahorro não ligou para o dono :(");
            else
                Console.WriteLine("Cachorro abanando o rabo");
        }

        public void reagir(bool dono)
        {
            if (dono == true)
                Console.WriteLine("Cachorro abanando o rabo e brincando com o dono");
            else
                Console.WriteLine("Cachorro avançando e rosnando");
        }


        public override string ToString()
        {
            return "\n\tCachorro\nPeso: \t\t" + getPeso() + "\nIdade: \t\t" + getIdade() + "\nMembros: \t" + getMembros() + "\nCor do pelo: \t" + getCorPelo() + "\nRaça: \t\t" + getRaca();
        }

    }
}
