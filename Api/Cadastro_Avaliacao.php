<?php

require_once 'config.php';

class Avaliacao
{
    public static function select(int $id)
    {
        $tabela = "avaliacao";
        $coluna = "id_avaliacao";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "SELECT * FROM $tabela WHERE $coluna = :id";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':id', $id);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return $stmt->fetch(PDO::FETCH_ASSOC);
        } else {
            throw new Exception("Sem registro de avaliação");
        }
    }

    public static function selectAll()
    {
        $tabela = "avaliacao";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "SELECT * FROM $tabela";
        $stmt = $connPdo->prepare($sql);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return $stmt->fetchAll(PDO::FETCH_ASSOC);
        } else {
            throw new Exception("Sem registros de avaliação");
        }
    }

    public static function insert($dados)
    {
        $tabela = "avaliacao";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "INSERT INTO $tabela (id_do_Produto, id_do_cliente, Pontuacao, Comentario, Data) 
                VALUES (:id_do_Produto, :id_do_cliente, :Pontuacao, :Comentario, :Data)";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':id_do_Produto', $dados['id_do_Produto']);
        $stmt->bindValue(':id_do_cliente', $dados['id_do_cliente']);
        $stmt->bindValue(':Pontuacao', $dados['Pontuacao']);
        $stmt->bindValue(':Comentario', $dados['Comentario']);
        $stmt->bindValue(':Data', $dados['Data']);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return 'Avaliação cadastrada com sucesso!';
        } else {
            throw new Exception("Erro ao inserir a avaliação");
        }
    }

    public static function delete($id)
    {
        $tabela = "avaliacao";
        $coluna = "id_avaliacao";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "DELETE FROM $tabela WHERE $coluna = :id";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':id', $id);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return 'Avaliação excluída com sucesso!';
        } else {
            throw new Exception("Erro ao excluir a avaliação");
        }
    }

    public static function update($id, $dados)
    {
        $tabela = "avaliacao";
        $coluna = "id_avaliacao";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "UPDATE $tabela 
                SET id_do_Produto = :id_do_Produto, id_do_cliente = :id_do_cliente, Pontuacao = :Pontuacao, 
                    Comentario = :Comentario, Data = :Data
                WHERE $coluna = :id";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':id', $id);
        $stmt->bindValue(':id_do_Produto', $dados['id_do_Produto']);
        $stmt->bindValue(':id_do_cliente', $dados['id_do_cliente']);
        $stmt->bindValue(':Pontuacao', $dados['Pontuacao']);
        $stmt->bindValue(':Comentario', $dados['Comentario']);
        $stmt->bindValue(':Data', $dados['Data']);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return 'Avaliação alterada com sucesso!';
        } else {
            throw new Exception("Erro ao alterar a avaliação");
        }
    }
}
?>
