<?php

    include 'Tabela_VinculoCliente.php';
    class Tabela_VinculoClienteService
    {
        public function get( $id = null )
        {
            if ($id){          
                return TabelaVinculoCliente::select($id) ;
            }else{
                return TabelaVinculoCliente::selectAll() ;
            }
        }

        public function post()
        {
            $dados = json_decode(file_get_contents('php://input'), true, 512);
            if ($dados == null){
                throw new Exception("Falta os dados para incluir !");
            }
            return VinculoCliente::insert($dados);
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
            return VinculoCliente::update($id,$dados);
        }

          public function delete($id = null)
        {
            if($id == null){
                throw new Exception("Falta o codigo!");
            }
            return VinculoCliente::delete($id);
        }
    }
?>