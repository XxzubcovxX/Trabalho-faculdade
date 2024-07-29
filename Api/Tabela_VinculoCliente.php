<?php

    require_once 'config.php' ;
      
    class TabelaVinculoCliente {
        
        public static function select(int $id){
            
            try {
                $tabelaVinculo = "vinculo_tabelascliente";
                $colunaid="id_vinculo_tabelasCliente ";
                $colunaCliente = "id_do_Cliente";
                $colunaAnimal = "id_do_animal";
                $colunaRegistro = "id_registro_medico_do_animal";
    
                $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
                $sql = "SELECT $colunaid, cliente.*, animal.*, registro_medico_do_animal.* 
                    FROM $tabelaVinculo
                    INNER JOIN cliente ON $tabelaVinculo.$colunaCliente = cliente.id_do_cliente
                    INNER JOIN animal ON $tabelaVinculo.$colunaAnimal = animal.id_do_animal
                    INNER JOIN registro_medico_do_animal ON $tabelaVinculo.$colunaRegistro = registro_medico_do_animal.id_registro_medico_do_animal
                    WHERE $tabelaVinculo.$colunaid = :id";
                $stmt = $connPdo->prepare($sql);
                $stmt->bindValue(':id', $id);
                $stmt->execute();
    
                if ($stmt->rowCount() > 0) {
                    $dados = $stmt->fetchAll(PDO::FETCH_ASSOC);
                    return $dados;
                } else {           
                    throw new Exception("Sem registros para o id do vinculo: $id");
                }
            } catch (Exception $e) {
                return array("error" => $e->getMessage());
            }
        }
    
        public static function selectAll()
        {
            try {
                $tabelaVinculo = "vinculo_tabelascliente";
                $colunaCliente = "id_do_Cliente";
                $colunaid="id_vinculo_tabelasCliente ";
                $colunaAnimal = "id_do_animal";
                $colunaRegistro = "id_registro_medico_do_animal";
    
                $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
                $sql = "SELECT  $colunaid ,cliente.*, animal.*, registro_medico_do_animal.*
                        FROM $tabelaVinculo
                        INNER JOIN cliente ON $tabelaVinculo.$colunaCliente = cliente.id_do_cliente
                        INNER JOIN animal ON $tabelaVinculo.$colunaAnimal = animal.id_do_animal
                        INNER JOIN registro_medico_do_animal ON $tabelaVinculo.$colunaRegistro = registro_medico_do_animal.id_registro_medico_do_animal";
                $stmt = $connPdo->prepare($sql);
                $stmt->execute();
    
                if ($stmt->rowCount() > 0) {
                    $dados = $stmt->fetchAll(PDO::FETCH_ASSOC);
                    return $dados;
                } else {           
                    throw new Exception("Sem registros");
                }
            } catch (Exception $e) {
                return array("error" => $e->getMessage());
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