<?php
    
    include 'Tabela_Vinculo.php';
    class Tabela_VinculoService
    {
        public function get( $id = null )
        {
            if ($id){           
                return Vinculo::select($id) ;
            }else{
                return Vinculo::selectAll() ;
            }
        }
    }
?>