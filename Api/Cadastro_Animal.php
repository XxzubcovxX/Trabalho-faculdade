<?php

    require_once 'config.php' ;
      
    class Animal {
        
        public static function select(int $id){
            
            $tabela = "animal";
            $coluna = "id_do_animal";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
             $sql = "select * from $tabela where $coluna = :id";
            $stmt = $connPdo->prepare($sql);  
            $stmt->bindValue(':id' , $id) ;
            $stmt->execute() ;
           
            if ($stmt->rowCount() > 0)
            {
                return $stmt->fetch(PDO::FETCH_ASSOC) ;
                
            }else{                
                throw new Exception("Sem registro do Animal");
            }
        }
        
        public static function selectAll()
        {
            $tabela = "animal";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "select * from $tabela" ;
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
            $tabela = "animal";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "insert into $tabela ( nome_do_animal, especie, raca, data_de_nascimento, altura_cm, peso_kg, comprimento_cm) values (:nome_do_animal, :especie, :raca, :data_de_nascimento, :altura_cm, :peso_kg,  :comprimento_cm)";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':nome_do_animal', $dados['nome_do_animal']);
            $stmt->bindValue(':especie', $dados['especie']);
            $stmt->bindValue(':raca', $dados['raca']);
            $stmt->bindValue(':data_de_nascimento', $dados['data_de_nascimento']);
            $stmt->bindValue(':altura_cm', $dados['altura_cm']);
            $stmt->bindValue(':peso_kg', $dados['peso_kg']);
            $stmt->bindValue(':comprimento_cm', $dados['comprimento_cm']);
            $stmt->execute();

            if ($stmt->rowCount() > 0)
            {                
                return 'Dados cadastrados com sucesso!' ;
            }else{
                throw new Exception("Erro ao inserir os dados");
            }
        }

        public static function delete($id)
        {
            $tabela = "animal";
            $coluna = "id_do_animal";
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
            $tabela = "animal";
            $coluna = "id_do_animal";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "update $tabela set  nome_do_animal=:nome_do_animal, especie=:especie, raca=:raca, data_de_nascimento=:data_de_nascimento, altura_cm=:altura_cm, peso_kg=:peso_kg,  comprimento_cm=:comprimento_cm where $coluna=:id";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':id', $id);
            $stmt->bindValue(':nome_do_animal', $dados['nome_do_animal']);
            $stmt->bindValue(':especie', $dados['especie']);
            $stmt->bindValue(':raca', $dados['raca']);
            $stmt->bindValue(':data_de_nascimento', $dados['data_de_nascimento']);
            $stmt->bindValue(':altura_cm', $dados['altura_cm']);
            $stmt->bindValue(':peso_kg', $dados['peso_kg']);
            $stmt->bindValue(':comprimento_cm', $dados['comprimento_cm']);
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