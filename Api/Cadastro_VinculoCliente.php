<?php

    require_once 'config.php' ;
      
    class VinculoCliente {
        
        public static function select(int $id){
            
            $tabela = "vinculo_tabelascliente";
            $coluna = "id_vinculo_tabelasCliente";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "SELECT * FROM $tabela WHERE $coluna = :id";
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
            $tabela = "vinculo_tabelascliente";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "SELECT * FROM $tabela";
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
            $tabela = "vinculo_tabelascliente";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "insert into $tabela ( id_do_cliente, id_do_animal, id_registro_medico_do_animal) values (:id_do_cliente, :id_do_animal, :id_registro_medico_do_animal)";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':id_do_cliente', $dados['id_do_cliente']);
            $stmt->bindValue(':id_do_animal', $dados['id_do_animal']);
            $stmt->bindValue(':id_registro_medico_do_animal', $dados['id_registro_medico_do_animal']);
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
            $tabela = "vinculo_tabelascliente";
            $coluna = "id_vinculo_tabelasCliente ";
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
            $tabela = "vinculo_tabelascliente";
            $coluna = "id_vinculo_tabelasCliente ";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "update $tabela set id_do_cliente=:id_do_cliente, id_do_animal=:id_do_animal, id_registro_medico_do_animal=:id_registro_medico_do_animal where $coluna=:id";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':id' , $id);
            $stmt->bindValue(':id_do_cliente', $dados['id_do_cliente']);
            $stmt->bindValue(':id_do_animal', $dados['id_do_animal']);
            $stmt->bindValue(':id_registro_medico_do_animal', $dados['id_registro_medico_do_animal']);
            $stmt->execute();

            if ($stmt->rowCount() > 0)
            {                
                return 'Dados alterados com sucesso!' ;
            }else{
                throw new Exception("Erro ao alterar os dados");
            }
        }
    }
?>    