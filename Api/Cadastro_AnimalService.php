<?php
  
    include 'Cadastro_Animal.php';
    class Cadastro_AnimalService
    {
        public function get( $id = null )
        {
            if ($id){           
                return Animal::select($id) ;
            }else{
                return Animal::selectAll() ;
            }

        }

        public function post()
        {
            $dados = json_decode(file_get_contents('php://input'), true, 512);
            if ($dados == null){
                throw new Exception("Falta os dados para incluir !");
            }
            return animal::insert($dados);
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
            return animal::update($id,$dados);
        }

        public function delete($id = null)
        {
            if($id == null){
                throw new Exception("Falta o codigo!");
            }
            return animal::delete($id);
        }
    }
?>