<?php
    
    include 'Cadastro_Categoria.php';
    class Cadastro_CategoriaService
    {
        public function get( $id = null )
        {
            if ($id){           
                return Categoria::select($id) ;
            }else{
                return Categoria::selectAll() ;
            }
        }

        public function post()
        {
            $dados = json_decode(file_get_contents('php://input'), true, 512);
            if ($dados == null){
                throw new Exception("Falta os dados para incluir !");
            }
            return Categoria::insert($dados);
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
            return Categoria::update($id,$dados);
        }
        
        public function delete($id = null)
        {
            if($id == null){
                throw new Exception("Falta o codigo!");
            }
            return Categoria::delete($id);
        }
    }
?>