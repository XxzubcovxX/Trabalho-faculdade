<?php
    
    include 'Cadastro_Cliente.php';
    class Cadastro_ClienteService
    {
        public function get( $id = null )
        {
            if ($id){           
                return cliente::select($id) ;
            }else{
                return cliente::selectAll() ;
            }
        }

        public function post()
        {
            $dados = json_decode(file_get_contents('php://input'), true, 512);
            if ($dados == null){
                throw new Exception("Falta os dados para incluir !");
            }
            return cliente::insert($dados);
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
            return cliente::update($id,$dados);
        }
        
        public function delete($id = null)
        {
            if($id == null){
                throw new Exception("Falta o codigo!");
            }
            return cliente::delete($id);
        }
    }
?>