<?php

    require_once 'config.php' ;  
    
    class Funcionario {
        

        
        public static function select(int $id){
            
            $tabela = "funcionarios";
            $coluna = "ID_funcionarios";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "select * from $tabela where $coluna = :id" ;
            $stmt = $connPdo->prepare($sql);  
            $stmt->bindValue(':id' , $id) ;
            $stmt->execute() ;
           
            if ($stmt->rowCount() > 0)
            {
                return $stmt->fetch(PDO::FETCH_ASSOC) ;
                
            }else{           
                throw new Exception("Sem registro do Funcionario");
            }
        }
        
        public static function selectAll()
        {
            $tabela = "funcionarios";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "select * from $tabela"  ;
            $stmt = $connPdo->prepare($sql);
            $stmt->execute() ;

            if ($stmt->rowCount() > 0)
            {
                return $stmt->fetchAll(PDO::FETCH_ASSOC) ;
            }else{
                throw new Exception("Sem registros");
            }
        }

        public static function insert($dados)
        {
            $tabela = "funcionarios";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "insert into $tabela (Nome,Sobrenome,Usuario,Senha,Grau, email, Telefone)VALUES(:Nome,:Sobrenome,:Usuario,:Senha,:Grau, :email, :Telefone);";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':Nome', $dados['Nome']);
            $stmt->bindValue(':Sobrenome', $dados['Sobrenome']);
            $stmt->bindValue(':Usuario', $dados['Usuario']);
            $stmt->bindValue(':Senha', $dados['Senha']);
            $stmt->bindValue(':Grau', $dados['Grau']);
            $stmt->bindValue(':email', $dados['email']);
            $stmt->bindValue(':Telefone', $dados['Telefone']);
            $stmt->execute() ;

            if ($stmt->rowCount() > 0)
            {                
                return 'Dados cadastrados com sucesso!' ;
            }else{
                throw new Exception("Erro ao inserir os dados");
            }
        }

        public static function delete($id)
        {
            $tabela = "funcionarios";
            $coluna = "ID_funcionarios";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "delete from $tabela where $coluna =:id";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':id' , $id);
            $stmt->execute() ;

            if ($stmt->rowCount() > 0)
            {                
                return 'Dados excluidos com sucesso!' ;
            }else{
                throw new Exception("Erro ao excluirir os dados");
            }
        }
        public static function update($id,$dados)
        { 
            $tabela = "funcionarios";
            $coluna = "ID_funcionarios";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "update $tabela set Nome =:Nome, Sobrenome =:Sobrenome, Usuario =:Usuario, Senha =:Senha, Grau =:Grau, email=:email, Telefone=:Telefone where $coluna=:id";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':id', $id);
            $stmt->bindValue(':Nome', $dados['Nome']);
            $stmt->bindValue(':Sobrenome', $dados['Sobrenome']);
            $stmt->bindValue(':Usuario', $dados['Usuario']);
            $stmt->bindValue(':Senha', $dados['Senha']);
            $stmt->bindValue(':Grau', $dados['Grau']);
            $stmt->bindValue(':email', $dados['email']);
            $stmt->bindValue(':Telefone', $dados['Telefone']);
            $stmt->execute() ;

            if ($stmt->rowCount() > 0)
            {                
                return 'Dados alterados com sucesso!' ;
            }else{
                throw new Exception("Erro ao alterar os dados");
            }
        }
    }
?>    