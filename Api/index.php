<?php
include 'Cadastro_FuncionariosService.php';
include 'Cadastro_RegistroMedicoService.php';
include 'Cadastro_ClienteService.php';
include 'Cadastro_AnimalService.php';   
include 'Cadastro_AvaliacaoService.php';
include 'Cadastro_CategoriaService.php';
include 'Cadastro_ProdutoService.php';
include 'Tabela_VinculoService.php';
include 'Tabela_VinculoClienteService.php';
include 'Vinculo_CategoriaProdutoService.php';
include 'Cadastro_VinculoClienteService.php';
include 'LoginService.php';
include 'AgendamentoService.php';

header("Content-Type: application/json; charset=UTF-8"); 
header("Access-Control-Allow-Origin: *");  
header("Access-Control-Allow-Methods: GET,POST,PUT,DELETE");
header("Access-Control: no-cache, no-store, must-revalidate");
header("Access-Control-Allow-Headers: *");
header("Access-Control-Max-Age: 86400");

if ($_GET['url']){

    $url = explode('/' , $_GET['url']);
     
    if ($url[0] === 'api' ){
   
        array_shift($url);
        $service = ucfirst($url[0]).'Service'; 
        array_shift($url);                     
        $method = strtolower( $_SERVER['REQUEST_METHOD']);

        try {
            // Corrigindo o nome da classe chamada
            $serviceClass = $service === 'Tabela_Vinculo_Categoria_Produto' ? 'VinculoCategoriaService' : $service;

            $response =  call_user_func_array(array(new $serviceClass, $method), $url);                
            http_response_code(200);
            echo json_encode(array('status' => 'success', 'data' => $response));                
        } catch (Exception $e) {
            http_response_code(404);
            echo json_encode(array('status' => 'error', 'data' => $e->getMessage()));                
        }  
    } 
}

?>