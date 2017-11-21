using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    /// <summary>
    /// Classe Model de Usuario
    /// </summary>
    public class UsuarioModel
    {
        private int id;
        private int codigo;
        private string nome;
        private string login;

        public UsuarioModel()
        {
        }

        /// <summary>
        /// Construtor com Recebimento de Parametros 
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nome"></param>
        /// <param name="login"></param>
        public UsuarioModel(int codigo, string nome, string login)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Login = login;
        }

        /// <summary>
        /// Variavel Id (Padrão para o NoSql LiteDB)
        /// </summary>
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

        /// <summary>
        /// Variavel Codigo para Identificação do Registro
        /// </summary>
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

        /// <summary>
        /// Variavel Nome 
        /// </summary>
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

        /// <summary>
        /// Variavel Login
        /// </summary>
        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }
    }
}