<?php

    require_once 'config.php' ;
      
    class registro_medico_do_animal {
        
        public static function select(int $id){

            $tabela = "registro_medico_do_animal";
            $coluna = "id_registro_medico_do_animal";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "select * from $tabela where $coluna = :id" ;
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
            $tabela = "registro_medico_do_animal";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "select * from $tabela";
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
            $tabela = "registro_medico_do_animal";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "insert into $tabela ( historico_de_vacinacao, medicamentos_prescritos, tratamentos_realizados, consultas_veterinarias, alergias, condicoes_de_saude, exames, resultados,observacoes) values ( :historico_de_vacinacao, :medicamentos_prescritos, :tratamentos_realizados, :consultas_veterinarias, :alergias, :condicoes_de_saude, :exames, :resultados, :observacoes)";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':historico_de_vacinacao', $dados['historico_de_vacinacao']);
            $stmt->bindValue(':medicamentos_prescritos', $dados['medicamentos_prescritos']);
            $stmt->bindValue(':tratamentos_realizados', $dados['tratamentos_realizados']);
            $stmt->bindValue(':consultas_veterinarias', $dados['consultas_veterinarias']);
            $stmt->bindValue(':alergias', $dados['alergias']);
            $stmt->bindValue(':condicoes_de_saude', $dados['condicoes_de_saude']);
            $stmt->bindValue(':exames', $dados['exames']);
            $stmt->bindValue(':resultados', $dados['resultados']);
            $stmt->bindValue(':observacoes', $dados['observacoes']);
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
            $tabela = "registro_medico_do_animal";
            $coluna = "id_registro_medico_do_animal";
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
            $tabela = "registro_medico_do_animal";
            $coluna = "id_registro_medico_do_animal";
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "update $tabela set  historico_de_vacinacao=:historico_de_vacinacao, medicamentos_prescritos=:medicamentos_prescritos, tratamentos_realizados=:tratamentos_realizados, consultas_veterinarias=:consultas_veterinarias, alergias=:alergias, condicoes_de_saude=:condicoes_de_saude, exames=:exames, resultados=:resultados, observacoes=:observacoes where $coluna=:id";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':id', $id);
            $stmt->bindValue(':historico_de_vacinacao', $dados['historico_de_vacinacao']);
            $stmt->bindValue(':medicamentos_prescritos', $dados['medicamentos_prescritos']);
            $stmt->bindValue(':tratamentos_realizados', $dados['tratamentos_realizados']);
            $stmt->bindValue(':consultas_veterinarias', $dados['consultas_veterinarias']);
            $stmt->bindValue(':alergias', $dados['alergias']);
            $stmt->bindValue(':condicoes_de_saude', $dados['condicoes_de_saude']);
            $stmt->bindValue(':exames', $dados['exames']);
            $stmt->bindValue(':resultados', $dados['resultados']);
            $stmt->bindValue(':observacoes', $dados['observacoes']);
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