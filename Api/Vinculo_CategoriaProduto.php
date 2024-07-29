<?php

    require_once 'config.php' ;  
    
    class Vinculo_Categoria {
        
        public static function select(int $id_categoria_animal, int $id_categoria_produto)
        {
            try {
                $tabelaVinculo = "vinculo_tabelas";
                $colunaProduto = "id_do_produto";
                $colunaCategoriaAnimal = "id_categoria_animal";
                $colunaCategoriaProduto = "id_categoria_produto";

                $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            
                $sql = "SELECT produtos_estoque.descricao, produtos_estoque.preco, produtos_estoque.imagem
                    FROM $tabelaVinculo
                    INNER JOIN produtos_estoque ON $tabelaVinculo.$colunaProduto = produtos_estoque.id_do_produto
                    WHERE $tabelaVinculo.$colunaCategoriaAnimal = :id_categoria_animal";
            
                // Adiciona a cláusula WHERE para o id da categoria de produto, se fornecido
                if ($id_categoria_produto !== null) {
                    $sql .= " AND $tabelaVinculo.$colunaCategoriaProduto = :id_categoria_produto";
                }
            
                $stmt = $connPdo->prepare($sql);  

                $stmt->bindValue(':id_categoria_animal', $id_categoria_animal);

                // Se o id da categoria de produto foi fornecido, vincula-o ao parâmetro
                if ($id_categoria_produto !== null) {
                    $stmt->bindValue(':id_categoria_produto', $id_categoria_produto);
                }
            
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
            throw new Exception("Sem registros para o id da categoria animal: $id_categoria_animal");
        }
        } catch (Exception $e) {
            return array("error" => $e->getMessage());
        }
    }
}
?>    