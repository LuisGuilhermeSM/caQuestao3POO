using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao3
{
    internal class Carro
    {
        string categoria;
        string marca_da_empresa;
        string modelo;
        int ano_de_fabricação;

        public string Categoria { get => categoria; set => categoria = value; }
        public string Marca_da_empresa { get => marca_da_empresa; set => marca_da_empresa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ano_de_fabricação { get => ano_de_fabricação; set => ano_de_fabricação = value; }

        public Carro() 
        { 
        }

        public Carro(string categoria, string marca_da_empresa, string modelo, int ano_de_fabricação)
        {
            Categoria = categoria;
            Marca_da_empresa = marca_da_empresa;
            Modelo = modelo;
            Ano_de_fabricação = ano_de_fabricação;

        }
    }
}
