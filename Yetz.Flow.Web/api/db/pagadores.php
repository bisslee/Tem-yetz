<?php
function ListaPagadores($conexao){
    try {
        $query =  "select * from pagadores";
        $resultado=mysqli_query($conexao,$query);

        $pagadores=mysqli_fetch_assoc($resultado);

        
    }
    catch (Exception $e) {
        echo 'Exce��o capturada: ',  $e->getMessage(), "\n";
        exit();
    }
    return $pagadores;
}
?>