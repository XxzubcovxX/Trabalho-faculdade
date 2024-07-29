<?php
    
    include 'Cadastro_Avaliacao.php';
    class Cadastro_AvaliacaoService
    {
        public function get( $id = null )
        {
            if ($id){           
                return Avaliacao::select($id) ;
            }else{
                return Avaliacao::selectAll() ;
            }
        }

        public function post()
        {
            $dados = json_decode(file_get_contents('php://input'), true, 512);
            if ($dados == null){
                throw new Exception("Falta os dados para incluir !");
            }
            return Avaliacao::insert($dados);
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
            return Avaliacao::update($id,$dados);
        }
        
        public function delete($id = null)
        {
            if($id == null){
                throw new Exception("Falta o codigo!");
            }
            return Avaliacao::delete($id);
        }
    }
?>