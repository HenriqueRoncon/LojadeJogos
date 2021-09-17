using MySql.Data.MySqlClient;
using Lojadejogos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lojadejogos.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
       

        public void CadastrarFuncionario(Funcionario func)
        {
            string data_sistema = Convert.ToDateTime(func.DataNasc).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbFuncionario values(@FuncionarioID,@Nome,@CPF,@RG,@DataNasc,@Endereco,@Celular,@Email,@Cargo)", con.ConectarBD());
            cmd.Parameters.Add("@FuncionarioID", MySqlDbType.Int32).Value = func.Codigo;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = func.Nome;
            cmd.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = func.CPF;
            cmd.Parameters.Add("@RG", MySqlDbType.VarChar).Value = func.RG;
            cmd.Parameters.Add("@DataNasc", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = func.Endereco;
            cmd.Parameters.Add("@Celular", MySqlDbType.VarChar).Value = func.Celular;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = func.Email;
            cmd.Parameters.Add("@Cargo", MySqlDbType.VarChar).Value = func.Cargo;
            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Funcionario ListarCodFuncionario(int cod)
        {
            var comando = String.Format("select * from tbFuncionario where FuncionarioID = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodFunc = cmd.ExecuteReader();
            return ListarTodosFuncionarios(DadosCodFunc).FirstOrDefault();
        }

        public List<Funcionario> ListarFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbFuncionario", con.ConectarBD());
            var DadosFuncionario = cmd.ExecuteReader();
            return ListarTodosFuncionarios(DadosFuncionario);
        }

        public List<Funcionario> ListarTodosFuncionarios(MySqlDataReader dt)
        {
            var TodosFuncionarios = new List<Funcionario>();
            while (dt.Read())
            {
                var FuncionarioTemp = new Funcionario()
                {
                    Codigo = dt["FuncionarioID"].ToString(),
                    Nome = dt["Nome"].ToString(),
                    CPF = dt["CPF"].ToString(),
                    RG = dt["RG"].ToString(),
                    DataNasc = DateTime.Parse(dt["DataNasc"].ToString()),
                    Endereco = dt["Endereco"].ToString(),
                    Celular = dt["Celular"].ToString(),
                    Email = dt["Email"].ToString(),
                    Cargo = dt["Cargo"].ToString(),
                };
                TodosFuncionarios.Add(FuncionarioTemp);
            }
            dt.Close();
            return TodosFuncionarios;
            }

            //CLIENTE

            public void CadastrarCliente(Cliente cli)
            {
                string data_sistema = Convert.ToDateTime(cli.DataNasc).ToString("yyyy-MM-dd");
                MySqlCommand cmd = new MySqlCommand("insert into tbCliente values(@CPF,@Nome,@DataNasc,@Email,@Celular,@Endereco)", con.ConectarBD());
                cmd.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = cli.CPF;
                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = cli.Nome;
                cmd.Parameters.Add("@DataNasc", MySqlDbType.DateTime).Value = data_sistema;
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = cli.Email;           
                cmd.Parameters.Add("@Celular", MySqlDbType.VarChar).Value = cli.Celular;
                cmd.Parameters.Add("@Endereco", MySqlDbType.VarChar).Value = cli.Endereco;
            
                cmd.ExecuteNonQuery();
                con.DesconectarBD();
            }

            public Cliente ListarCodCliente(int cod)
            {
                var comando = String.Format("select * from tbCliente where CPF = {0}", cod);
                MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
                var DadosCodCli = cmd.ExecuteReader();
                return ListarTodosClientes(DadosCodCli).FirstOrDefault();
            }

            public List<Cliente> ListarCliente()
            {
                MySqlCommand cmd = new MySqlCommand("select * from tbCliente", con.ConectarBD());
                var DadosCliente = cmd.ExecuteReader();
                return ListarTodosClientes(DadosCliente);
            }

            public List<Cliente> ListarTodosClientes(MySqlDataReader dt)
            {
                var TodosClientes = new List<Cliente>();
                while (dt.Read())
                {
                    var ClienteTemp = new Cliente()
                    {
                        CPF = dt["CPF"].ToString(),
                        Nome = dt["Nome"].ToString(),                                                
                        DataNasc = DateTime.Parse(dt["DataNasc"].ToString()),
                        Email = dt["Email"].ToString(),
                        Celular = dt["Celular"].ToString(),
                        Endereco = dt["Endereco"].ToString(),
                        
                                            
                    };
                    TodosClientes.Add(ClienteTemp);
                }
                dt.Close();
                return TodosClientes;
            }

        //JOGO

        public void CadastrarJogo(Jogo jogo)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbJogo values(@JogoID,@Nome,@Versao,@Desenvolvedor,@Genero,@FaixaEtaria,@Plataforma,@AnoLanc,@Sinopse)", con.ConectarBD());
            cmd.Parameters.Add("@JogoID", MySqlDbType.VarChar).Value = jogo.Codigo;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = jogo.Nome;
            cmd.Parameters.Add("@Versao", MySqlDbType.VarChar).Value = jogo.Versao;
            cmd.Parameters.Add("@Desenvolvedor", MySqlDbType.VarChar).Value = jogo.Desenvolvedor;
            cmd.Parameters.Add("@Genero", MySqlDbType.VarChar).Value = jogo.Genero;
            cmd.Parameters.Add("@FaixaEtaria", MySqlDbType.VarChar).Value = jogo.FaixaEtaria;
            cmd.Parameters.Add("@Plataforma", MySqlDbType.VarChar).Value = jogo.Plataforma;
            cmd.Parameters.Add("@AnoLanc", MySqlDbType.VarChar).Value = jogo.AnoLanc;
            cmd.Parameters.Add("@Sinopse", MySqlDbType.VarChar).Value = jogo.Sinopse;

            cmd.ExecuteNonQuery();
            con.DesconectarBD();
        }

        public Jogo ListarCodJogo(int cod)
        {
            var comando = String.Format("select * from tbJogo where JogoID = {0}", cod);
            MySqlCommand cmd = new MySqlCommand(comando, con.ConectarBD());
            var DadosCodJogo = cmd.ExecuteReader();
            return ListarTodosJogos(DadosCodJogo).FirstOrDefault();
        }

        public List<Jogo> ListarJogo()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tbJogo", con.ConectarBD());
            var DadosJogos = cmd.ExecuteReader();
            return ListarTodosJogos(DadosJogos);
        }

        public List<Jogo> ListarTodosJogos(MySqlDataReader dt)
        {
            var TodosJogos = new List<Jogo>();
            while (dt.Read())
            {
                var JogoTemp = new Jogo()
                {
                    Codigo = dt["JogoID"].ToString(),
                    Nome = dt["Nome"].ToString(),
                    Versao = dt["Versao"].ToString(),
                    Desenvolvedor = dt["Desenvolvedor"].ToString(),
                    Genero = dt["Genero"].ToString(),
                    FaixaEtaria = dt["FaixaEtaria"].ToString(),
                    Plataforma = dt["Plataforma"].ToString(),
                    AnoLanc = dt["AnoLanc"].ToString(),
                    Sinopse = dt["Sinopse"].ToString(),


                };
                TodosJogos.Add(JogoTemp);
            }
            dt.Close();
            return TodosJogos;
        }
    }
}