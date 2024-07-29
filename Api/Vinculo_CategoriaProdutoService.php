<?php
    
    include 'Vinculo_CategoriaProduto.php';
    class Vinculo_CategoriaProdutoService
    {
        public function get($id_categoria_animal, $id_categoria_produto)
        {
            return Vinculo_Categoria::select($id_categoria_animal, $id_categoria_produto);
        }

    }
?>