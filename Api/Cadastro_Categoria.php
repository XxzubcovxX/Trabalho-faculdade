<?php

require_once 'config.php';

class Categoria
{

    public static function select(int $id)
    {

        $tabela = "categoria";
        $coluna = "id_categoria_dos_produtos";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "SELECT * FROM $tabela WHERE $coluna = :id";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':id', $id);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return $stmt->fetch(PDO::FETCH_ASSOC);
        } else {
            throw new Exception("Sem registro do Produto");
        }
    }

    public static function selectAll()
    {
        $tabela = "categoria";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "SELECT * FROM $tabela";
        $stmt = $connPdo->prepare($sql);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return $stmt->fetchAll(PDO::FETCH_ASSOC);
        } else {
            throw new Exception("Sem registros");
        }
    }

    public static function insert($dados)
    {
        $tabela = "categoria";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "INSERT INTO $tabela (nome_da_categoria, descricao) VALUES (:nome_da_categoria, :descricao)";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':nome_da_categoria', $dados['nome_da_categoria']);
        $stmt->bindValue(':descricao', $dados['descricao']);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return 'Dados cadastrados com sucesso!';
        } else {
            throw new Exception("Erro ao inserir os dados");
        }
    }

    public static function delete($id)
    {
        $tabela = "categoria";
        $coluna = "id_categoria_dos_produtos";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "DELETE FROM $tabela WHERE $coluna = :id";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':id', $id);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return 'Dados excluídos com sucesso!';
        } else {
            throw new Exception("Erro ao excluir os dados");
        }
    }

    public static function update($id, $dados)
    {
        $tabela = "categoria";
        $coluna = "id_categoria_dos_produtos";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "UPDATE $tabela SET nome_da_categoria = :nome_da_categoria, descricao = :descricao WHERE $coluna = :id";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':id', $id);
        $stmt->bindValue(':nome_da_categoria', $dados['nome_da_categoria']);
        $stmt->bindValue(':descricao', $dados['descricao']);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return 'Dados alterados com sucesso!';
        } else {
            throw new Exception("Erro ao alterar os dados");
        }
    }
}
?>