<?php

    include 'Cadastro_RegistroMedico.php';
    class Cadastro_RegistroMedicoService
    {
        public function get( $id = null )
        {
            if ($id){          
                return registro_medico_do_animal::select($id) ;
            }else{
                return registro_medico_do_animal::selectAll() ;
            }
        }

        public function post()
        {
            $dados = json_decode(file_get_contents('php://input'), true, 512);
            if ($dados == null){
                throw new Exception("Falta os dados para incluir !");
            }
            return registro_medico_do_animal::insert($dados);
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
            return registro_medico_do_animal::update($id,$dados);
        }

          public function delete($id = null)
        {
            if($id == null){
                throw new Exception("Falta o codigo!");
            }
            return registro_medico_do_animal::delete($id);
        }
    }
?>