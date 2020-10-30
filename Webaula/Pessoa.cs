using System;
using System.Collections.Generic;
using System.Text;

namespace Webaula
{
    class _Pessoa
    {
        private DateTime _DataCadastro;
        private int _Codigo;
        private string _Nome;
        private string _Cpf;
        private string _Endereco;
        private string _Cidade;
        private string _Uf;
        private string _Cep;
        public DateTime DataCadastro
        {
            get { return _DataCadastro; }
            set { _DataCadastro = value; }
        }

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Cpf
        {
            get { return _Cpf; }
            set { _Cpf = value; }
        }

        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }

        public string Cidade
        {
            get { return _Cidade; }
            set { _Cidade = value; }
        }

        public string Uf
        {
            get { return _Uf; }
            set { _Uf = value; }
        }

        public string Cep
        {
            get { return _Cep; }
            set { _Cep = value; }
        }
    }

}