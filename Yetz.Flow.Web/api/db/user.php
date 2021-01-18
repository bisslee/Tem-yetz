<?php


function Login($conexao, $email, $senha){

    $resultado=mysqli_query($conexao, "select * from usuarios where email='{$email}' and password='{$senha}'");

    $usuario=mysqli_fetch_assoc($resultado);

    return $usuario;
}

function NewPassword($conexao, $email){
    $senha = uniqid();
    $senha = substr($senha,6);
    $senhaFinal = sha1($email.":".$senha);
    $query="update usuarios set password='{$senhaFinal}' where  email='{$email}' ";

    $resultado = mysqli_query($conexao, $query);

    $senhaFinal=mysqli_fetch_assoc($resultado);

    return $senhaFinal;
}

?>