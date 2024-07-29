<?php
    
    include 'Agendamento.php';
    class AgendamentoService
    {
        public function get( $id = null )
        {
            if ($id){           
                return Agendamento::select($id) ;
            }else{
                return Agendamento::selectAll() ;
            }
        }

        public function post()
        {
            $dados = json_decode(file_get_contents('php://input'), true, 512);
            if ($dados == null){
                throw new Exception("Falta os dados para incluir !");
            }
            return Agendamento::insert($dados);
        }

        public function put($cpf = null)
        {
            if ($cpf == null){
                throw new Exception("Falta o codigo !");
            }
            $dados = json_decode(file_get_contents('php://input'), true, 512);
            if ($dados == null){
                throw new Exception("Falta informação!");
            }
            return Agendamento::update($cpf,$dados);
        }
        
        public function delete($cpf = null)
        {
            if($cpf == null){
                throw new Exception("Falta o codigo!");
            }
            return Agendamento::delete($cpf);
        }
    }
?>