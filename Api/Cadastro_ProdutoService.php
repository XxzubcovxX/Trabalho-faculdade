<?php
    
    include 'Cadastro_Produto.php';
    class Cadastro_ProdutoService
    {
        public function get( $id = null )
        {
            if ($id){           
                return Produto::select($id) ;
            }else{
                return Produto::selectAll() ;
            }
        }

        public function post()
        {
            $dados = json_decode(file_get_contents('php://input'), true, 512);
            if ($dados == null){
                throw new Exception("Falta os dados para incluir !");
            }
            return Produto::insert($dados);
        }

        public function put($id = null)
        {
            if ($id == null){
                throw new Exception("Falta o codigo !");
            }
            $dados = json_decode(file_get_contents('php://input'), true, 512);
            if ($dados == null){
                throw new Exception("Falta informação!");
            }
            return Produto::update($id,$dados);
        }
        
        public function delete($id = null)
        {
            if($id == null){
                throw new Exception("Falta o codigo!");
            }
            return Produto::delete($id);
        }
    }
?>