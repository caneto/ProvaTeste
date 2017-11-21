using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ClienteModel
    {
        private int id;
        private int codigo;
        private string nome;
        private string sobrenome;
        private string email;
        private string endereco;
        private string telefone;

        public ClienteModel()
        {
        }

        public ClienteModel(int codigo, string nome, string sobrenome, string email, string endereco, string telefone)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }
        
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }

        }


        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }

        }


        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }

        }


        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }

        }

        public string Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }

        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }

        }
    }
}