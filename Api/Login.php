<?php
// Arquivo de Regras de negócio
require_once 'config.php' ;
class Login 
{   
    //Uma função para verificar ou avalidar login e senha  
    public static function verificarLogin($dados)
    {
        $tabela = "funcionarios";
        $colunaLogin = "Usuario";
        $colunaSenha = "Senha";

        // conectando com o banco de dados através do PDO
        // pegando as informações do config.php (variáveis globais)        
        $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);        
        
        //comando que será executado no banco de dados para avalidar login e senha
        $sql = "select ID_funcionarios , Grau from $tabela where $colunaLogin=:Usuario and $colunaSenha=:Senha" ;
        // preparando o comando Select para ser executado
        $stmt = $connPdo->prepare($sql);
        // configurando o parametro de busca
        $stmt->bindValue(':Usuario' , $dados['Usuario']) ;
        $stmt->bindValue(':Senha' , $dados['Senha']) ;
        // executando o comando select no banco de dados
        $stmt->execute() ;
        
        if ($stmt->rowCount() > 0)
        {   // se houve retorno de dados
            //var_dump( $stmt->fetch(PDO::FETCH_ASSOC) );

            // retornando os dados do banco de dados
            return $stmt->fetch(PDO::FETCH_ASSOC) ;           
        }else{
            // se não houve retorno de dados
            throw new Exception("Login incorreto");
        }

    }
}