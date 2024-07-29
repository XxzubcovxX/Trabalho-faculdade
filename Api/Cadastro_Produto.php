<?php
require_once 'config.php';

class Produto
{

    public static function select(int $id)
    {
        try {
            $tabela = "produtos_estoque";
            $coluna = "id_do_produto";
            $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
            $sql = "SELECT * FROM $tabela WHERE $coluna = :id";
            $stmt = $connPdo->prepare($sql);
            $stmt->bindValue(':id', $id);
            $stmt->execute();

            if ($stmt->rowCount() > 0) {
                $produto = $stmt->fetch(PDO::FETCH_ASSOC);
                // Verifica se a coluna imagem existe
                if (isset($produto['imagem'])) {
                    // Converte a imagem para base64
                    $imagem_base64 = base64_encode($produto['imagem']);
                    // Remove a imagem do array original
                    unset($produto['imagem']);
                    // Adiciona a imagem codificada em base64 ao array
                    $produto['imagem_base64'] = $imagem_base64;
                }
                return $produto;
            } else {
                throw new Exception("Sem registro do Produto");
            }
        } catch (Exception $e) {
            return array("error" => $e->getMessage());
        }
    }

    public static function selectAll()
    {
        try {
            $tabela = "produtos_estoque";
            $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
            $sql = "SELECT * FROM $tabela";
            $stmt = $connPdo->prepare($sql);
            $stmt->execute();

            if ($stmt->rowCount() > 0) {
                $produtos = $stmt->fetchAll(PDO::FETCH_ASSOC);
                foreach ($produtos as &$produto) {
                    // Verifica se a coluna imagem existe
                    if (isset($produto['imagem'])) {
                        // Converte a imagem para base64
                        $imagem_base64 = base64_encode($produto['imagem']);
                        // Remove a imagem do array original
                        unset($produto['imagem']);
                        // Adiciona a imagem codificada em base64 ao array
                        $produto['imagem_base64'] = $imagem_base64;
                    }
                }
                return $produtos;
            } else {
                throw new Exception("Sem registros");
            }
        } catch (Exception $e) {
            return array("error" => $e->getMessage());
        }
    }

    public static function insert($dados)
{
    try {
        $tabela = "produtos_estoque";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "INSERT INTO $tabela (nome_do_produto, preco, imagem, descricao, quantidade_estoque, nota , data_cadastro) VALUES (:nome_do_produto, :preco, :imagem, :descricao, :quantidade_estoque, :nota, :data_cadastro)";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':nome_do_produto', $dados['nome_do_produto']);
        $stmt->bindValue(':preco', $dados['preco']);

        // Decodificando a imagem de base64 para binário
        $imagem_binaria = base64_decode($dados['imagem_base64']);
        $stmt->bindValue(':imagem', $imagem_binaria, PDO::PARAM_LOB);

        $stmt->bindValue(':descricao', $dados['descricao']);
        $stmt->bindValue(':quantidade_estoque', $dados['quantidade_estoque']);
        $stmt->bindValue(':nota', $dados['nota']);
        $stmt->bindValue(':data_cadastro', $dados['data_cadastro']);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return 'Dados cadastrados com sucesso!';
        } else {
            throw new Exception("Erro ao inserir os dados");
        }
    } catch (Exception $e) {
        return 'Erro: ' . $e->getMessage();
    }
}


    public static function delete($id)
    {
        $tabela = "produtos_estoque";
        $coluna = "id_do_produto";
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
    try {
        $tabela = "produtos_estoque";
        $coluna = "id_do_produto";
        $connPdo = new PDO(dbDrive . ':host=' . dbHost . '; dbname=' . dbName, dbUser, dbPass);
        $sql = "UPDATE $tabela SET nome_do_produto = :nome_do_produto, preco = :preco, imagem = :imagem, descricao = :descricao, quantidade_estoque = :quantidade_estoque, nota = :nota WHERE $coluna = :id";
        $stmt = $connPdo->prepare($sql);
        $stmt->bindValue(':id', $id);
        $stmt->bindValue(':nome_do_produto', $dados['nome_do_produto']);
        $stmt->bindValue(':preco', $dados['preco']);

        // Decodificando a imagem de base64 para binário
        $imagem_binaria = base64_decode($dados['imagem_base64']);
        $stmt->bindValue(':imagem', $imagem_binaria, PDO::PARAM_LOB);

        $stmt->bindValue(':descricao', $dados['descricao']);
        $stmt->bindValue(':quantidade_estoque', $dados['quantidade_estoque']);
        $stmt->bindValue(':nota', $dados['nota']);
        $stmt->execute();

        if ($stmt->rowCount() > 0) {
            return 'Dados alterados com sucesso!';
        } else {
            throw new Exception("Erro ao alterar os dados");
        }
    } catch (Exception $e) {
        return 'Erro: ' . $e->getMessage();
    }
}
}

?>