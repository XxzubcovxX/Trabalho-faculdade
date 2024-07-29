<?php
require_once 'config.php';

class Agendamento
{
    public static function select($cpf)
    {
        $tabela = "agendamento";
        $coluna = "CPF"; // Busca apenas pelo CPF
        $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
        
        // Constrói a consulta SQL
        $sql = "SELECT * FROM $tabela WHERE $coluna = :cpf";
    
        $stmt = $connPdo->prepare($sql);  
    
        // Vincula o parâmetro à consulta SQL
        $stmt->bindValue(':cpf', $cpf); 
        $stmt->execute() ;
       
        if ($stmt->rowCount() > 0)
        {
            return $stmt->fetch(PDO::FETCH_ASSOC) ;
            
        } else {           
            throw new Exception("Sem registro de Agendamento");
        }
    }
    


    public static function selectAll()
        {
            $tabela = "agendamento";
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
        $tabela = "agendamento";
        $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
        $sql = "insert into $tabela (nomeCompleto, CPF, telefone, email, nomeAnimal, racaAnimal, idadeAnimal, pesoAnimal, tipoServico, dataAgendamento, horaAgendamento) values (:nomeCompleto, :CPF, :telefone, :email, :nomeAnimal, :racaAnimal, :idadeAnimal, :pesoAnimal, :tipoServico, :dataAgendamento, :horaAgendamento)";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':nomeCompleto', $dados['nomeCompleto']);
        $stmt->bindValue(':CPF', $dados['CPF']);
        $stmt->bindValue(':telefone', $dados['telefone']);
        $stmt->bindValue(':email', $dados['email']);
        $stmt->bindValue(':nomeAnimal', $dados['nomeAnimal']);
        $stmt->bindValue(':racaAnimal', $dados['racaAnimal']);
        $stmt->bindValue(':idadeAnimal', $dados['idadeAnimal']);
        $stmt->bindValue(':pesoAnimal', $dados['pesoAnimal']);
        $stmt->bindValue(':tipoServico', $dados['tipoServico']);
        $stmt->bindValue(':dataAgendamento', $dados['dataAgendamento']);
        $stmt->bindValue(':horaAgendamento', $dados['horaAgendamento']);
        $stmt->execute() ;

        if ($stmt->rowCount() > 0)
        {                
            return 'Dados cadastrados com sucesso!' ;
        }else{
            throw new Exception("Erro ao inserir os dados");
        }
    }

    public static function update($cpf, $dados)
{
    $tabela = "agendamento";
    $coluna = "cpf";
    $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
    
    // Atualiza os dados usando o CPF como referência
    $sql = "UPDATE $tabela SET nomeCompleto = :nomeCompleto, telefone = :telefone, email = :email, nomeAnimal = :nomeAnimal, racaAnimal = :racaAnimal, idadeAnimal = :idadeAnimal, pesoAnimal = :pesoAnimal, tipoServico = :tipoServico, dataAgendamento = :dataAgendamento, horaAgendamento = :horaAgendamento WHERE $coluna = :cpf";
    
    $stmt = $connPdo->prepare($sql);
    $stmt->bindValue(':cpf', $cpf); // Altera o valor do CPF para o parâmetro $cpf
    $stmt->bindValue(':nomeCompleto', $dados['nomeCompleto']);
    $stmt->bindValue(':telefone', $dados['telefone']);
    $stmt->bindValue(':email', $dados['email']);
    $stmt->bindValue(':nomeAnimal', $dados['nomeAnimal']);
    $stmt->bindValue(':racaAnimal', $dados['racaAnimal']);
    $stmt->bindValue(':idadeAnimal', $dados['idadeAnimal']);
    $stmt->bindValue(':pesoAnimal', $dados['pesoAnimal']);
    $stmt->bindValue(':tipoServico', $dados['tipoServico']);
    $stmt->bindValue(':dataAgendamento', $dados['dataAgendamento']);
    $stmt->bindValue(':horaAgendamento', $dados['horaAgendamento']);
    $stmt->execute();

    if ($stmt->rowCount() > 0) {
        return 'Dados alterados com sucesso!';
    } else {
        throw new Exception("Erro ao alterar os dados");
    }
}


public static function delete($cpf)
{
    $tabela = "agendamento";
    $coluna = "cpf"; // Alterado para usar o CPF como referência
    $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
    $sql = "DELETE FROM $tabela WHERE $coluna = :cpf"; // Query modificada para usar o CPF
    $stmt = $connPdo->prepare($sql);
    $stmt->bindValue(':cpf', $cpf);
    $stmt->execute();

    if ($stmt->rowCount() > 0) {
        return 'Agendamento deletado com sucesso!';
    } else {
        throw new Exception("Erro ao deletar o agendamento");
    }
}
}
?>