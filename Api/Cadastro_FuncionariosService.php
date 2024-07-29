<?php

include 'Cadastro_Funcionarios.php';

class Cadastro_FuncionariosService
{
    public function get($id = null)
    {
        if ($id) {
            return Funcionario::select($id);
        } else {
            return Funcionario::selectAll();
        }
    }

    public function post()
    {
        $dados = json_decode(file_get_contents('php://input'), true, 512);
        if ($dados == null) {
            throw new Exception("Falta os dados para incluir !");
        }
        return Funcionario::insert($dados);
    }

    public function put($id = null)
    {
        if ($id == null) {
            throw new Exception("Falta o codigo !");
        }
        $dados = json_decode(file_get_contents('php://input'), true, 512);
        if ($dados == null) {
            throw new Exception("Falta informação!");
        }
        return Funcionario::update($id, $dados);
    }

    public function delete($id = null)
    {
        if ($id == null) {
            throw new Exception("Falta o codigo!");
        }
        return Funcionario::delete($id);
    }

   
}
?>
