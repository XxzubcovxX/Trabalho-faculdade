<?php

    require_once 'config.php' ;  
    
class Vinculo {
    public static function select(int $id_categoria_animal)
    {
        try {
            $tabelaVinculo = "vinculo_tabelas";
            $colunaProduto = "id_do_produto";
            $colunaCategoriaAnimal = "id_categoria_animal";
        
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "SELECT produtos_estoque.descricao, produtos_estoque.preco, produtos_estoque.imagem
                    FROM $tabelaVinculo
                    INNER JOIN produtos_estoque ON $tabelaVinculo.$colunaProduto = produtos_estoque.id_do_produto
                    WHERE $tabelaVinculo.$colunaCategoriaAnimal = :id_categoria_animal";
            $stmt = $connPdo->prepare($sql);  
            $stmt->bindValue(':id_categoria_animal', $id_categoria_animal);
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
        
    public static function selectAll()
    {
        try {
            $tabelaVinculo = "vinculo_tabelas";
            $colunaProduto = "id_do_produto";
            $colunaCategoriaAnimal = "id_categoria_animal";
        
            $connPdo = new PDO(dbDrive.':host='.dbHost.'; dbname='.dbName, dbUser, dbPass);
            $sql = "SELECT produtos_estoque.descricao, produtos_estoque.preco, produtos_estoque.imagem
                    FROM $tabelaVinculo
                    INNER JOIN produtos_estoque ON $tabelaVinculo.$colunaProduto = produtos_estoque.id_do_produto";
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
}
?>