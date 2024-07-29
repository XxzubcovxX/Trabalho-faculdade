<?php

    require_once 'config.php' ;  
    
    class Cliente {
        
        public static function select(int $id){
            
            $tabela = "cliente";
            $coluna = "id_do_cliente";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "select * from $tabela where $coluna = :id" ;
            $stmt = $connPdo->prepare($sql);  
            $stmt->bindValue(':id' , $id) ;
            $stmt->execute() ;
           
            if ($stmt->rowCount() > 0)
            {
                return $stmt->fetch(PDO::FETCH_ASSOC) ;
                
            }else{           
                throw new Exception("Sem registro do Cliente");
            }
        }
        
        public static function selectAll()
        {
            $tabela = "cliente";
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
            $tabela = "cliente";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "insert into $tabela (nome_do_cliente, sobrenome, cpf, data_de_nascimento, endereco, cidade, uf, cep, telefone_fixo, telefone_celular, email, genero, bairro, numero) values (:nome_do_cliente, :sobrenome, :cpf,:data_de_nascimento, :endereco, :cidade, :uf, :cep, :telefone_fixo, :telefone_celular, :email, :genero, :bairro, :numero)";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':nome_do_cliente', $dados['nome_do_cliente']);
            $stmt->bindValue(':sobrenome', $dados ['sobrenome']);
            $stmt->bindValue(':cpf', $dados['cpf']);
            $stmt->bindValue(':data_de_nascimento', $dados['data_de_nascimento']);
            $stmt->bindValue(':endereco', $dados['endereco']);
            $stmt->bindValue(':cidade', $dados['cidade']);
            $stmt->bindValue(':uf', $dados['uf']);
            $stmt->bindValue(':cep', $dados['cep']);
            $stmt->bindValue(':telefone_fixo', $dados['telefone_fixo']);
            $stmt->bindValue(':telefone_celular', $dados['telefone_celular']);
            $stmt->bindValue(':email', $dados['email']);
            $stmt-> bindValue(':genero', $dados['genero']);
            $stmt->bindValue(':bairro', $dados['bairro']);
            $stmt->bindValue(':numero', $dados['numero']);
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
            $tabela = "cliente";
            $coluna = "id_do_cliente";
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
            $tabela = "cliente";
            $coluna = "id_do_cliente";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "update $tabela set nome_do_cliente =:nome_do_cliente, sobrenome=:sobrenome, cpf =:cpf, data_de_nascimento =:data_de_nascimento, endereco =:endereco, cidade =:cidade, uf =:uf, cep =:cep, telefone_fixo =:telefone_fixo, telefone_celular =:telefone_celular, email =:email, genero=:genero, bairro=:bairro, numero=:numero  where $coluna=:id";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':id', $id);
            $stmt->bindValue(':nome_do_cliente', $dados['nome_do_cliente']);
            $stmt->bindValue(':sobrenome', $dados['sobrenome']);
            $stmt->bindValue(':cpf', $dados['cpf']);
            $stmt->bindValue(':data_de_nascimento', $dados['data_de_nascimento']);
            $stmt->bindValue(':endereco', $dados['endereco']);
            $stmt->bindValue(':bairro', $dados['bairro']);
            $stmt->bindValue(':numero', $dados['numero']);
            $stmt->bindValue(':cidade', $dados['cidade']);
            $stmt->bindValue(':uf', $dados['uf']);
            $stmt->bindValue(':cep', $dados['cep']);
            $stmt->bindValue(':telefone_fixo', $dados['telefone_fixo']);
            $stmt->bindValue(':telefone_celular', $dados['telefone_celular']);
            $stmt->bindValue(':email', $dados['email']);
            $stmt-> bindValue(':genero', $dados['genero']);
            
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