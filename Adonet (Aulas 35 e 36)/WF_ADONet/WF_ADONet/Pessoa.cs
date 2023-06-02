using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_ADONet
{
    //create database adonet;

    //create table pessoas
    //(
    //id integer primary key identity,
    //nome varchar(50) not null,
    //profissao varchar(30)
    //)

    //create login atos with password='senha123';
    //create user usuario from login atos;
    //exec sp_addrolemember 'DB_DATAREADER', 'usuario';
    //exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

    //insert into pessoas values ('Ze', 'Programador');

    //select * from pessoas
    //select * from pessoas where nome = 'Ze';

    //create login cavalaro with password='1234';
    //create user cavalaro from login cavalaro;
    //exec sp_addrolemember 'DB_DATAREADER', 'cavalaro';
    //exec sp_addrolemember 'DB_DATAWRITER', 'cavalaro';





    internal class Pessoa
    {
        public int id;
        public string nome;
        public string profissao;


        public bool gravarPessoa()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into pessoas " +
                " values (@nome, @profissao);";

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@profissao", System.Data.SqlDbType.VarChar);

            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = profissao;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool excluir()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction trans = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = trans;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from pessoas where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = id;

            try
            {
                command.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool atualizar()
        {
            Banco bd = new Banco();



            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update pessoas set nome = @nome, " +
                "  profissao = @profissao where id = @id";
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@profissao", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = profissao;
            cmd.Parameters[2].Value = id;



            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;



            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public Pessoa consultaPessoa(int id)
        {
            Banco bd = new Banco();



            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select * from pessoas", cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.id = reader.GetInt32(0);
                        this.nome = reader.GetString(1);
                        this.profissao = reader.GetString(2);



                        return this;
                    }
                }
                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}