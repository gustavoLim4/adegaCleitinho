using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adegaCleitinho
{
    internal class variaveis
    {
        public static string usuario , senha ,nivel;

        public static double somageralCompras;

        public static string funcao;

        public static int linhaSelecionada;


        //funcionario

        public static string enderecoServidorFtp = "ftp://127.0.0.1/img/";
        public static string usuarioFtp = "adegacleitinho";
        public static string senhaFtp = "1234";


        public static int   qtdeFuncionario , qtdeFornecedores , qtdeCliente , qtCompras;

        public static string nomeFuncionario,  cargoFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario, telefoneFuncionario 
           , statusFuncionario, fotoFuncionario , atFotofuncionario, caminhoFotofuncionario;

        public static DateTime dataNascFuncionario, admissaoFuncionaro;

        public static int codInstrutores;
        //funcionario fim 


        //clientes

        public static string nomeUsuario, emailUsuario, senhaUsuario, telefoneUsuario, enderecoUsuario, cepUsuario, statusUsuario;
        public static DateTime dataNascUsuario;
        public static int codUsuario;
        //clientes



        //Fornecedores

        public static string nomeFornecedor, telefoneFornecedor, enderecoFornecedor, cepFornecedor, cnpjFornecedor, statusFornecedor;

        //Fornecedores



        //E-mail

        public static string nomeContato, emailContato, telContato, assuntoContato, horaContado, statusContato;
        public static DateTime dataContado;

        //E-mail

    }
}
