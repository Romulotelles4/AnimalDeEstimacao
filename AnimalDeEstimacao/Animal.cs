using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDeEstimacao
{
    internal class Animal
    {
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        
        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set { 
                if(value == "cachorro" || value == "gato" || value == "peixe")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "peixe";
                }
            }
        }


    }
}
