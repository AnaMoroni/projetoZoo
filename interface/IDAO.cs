using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aplicacaoZoologico.models;
using MySql.Data.MySqlClient;

namespace aplicacaoZoologico 
{
    internal interface IDAO
    {
        void Salvar(Animal a);

        void Deletar(int id);

        void Atualizar(Animal animal);

    }
}
