<?php
    include("../db/connectDb.php");
    include("../db/user.php");
    include("tools.php");
    include("password.php");
    $msg = mysqli_error($conexao);

    if ($msg!= null)
    {
        Redirect("/index.php?msg={$msg}", false);
    }

    $email = $_POST["email"];
    $senha = $_POST["senha"];
    echo " // e-mail:".$email;
    echo " // senha:".$senha;

    $senhaFinal = sha1($email.":".$senha);
    echo " // senhaFinal: ".$senhaFinal;
    $usuario = login($conexao, $email, $senhaFinal);
    echo " // nome: ".$usuario['nome'];
    
    session_start();
    $_SESSION['email'] = $email;
    $_SESSION['usuario'] = $usuario;


    if($usuario!=null) {

        echo " // Entrei no envia pra Home: ";        
        Redirect("/home.php");
    } else {
        echo " // Entrei no envia pra index: ";
        Redirect("/index.php?msg=".urlencode("E-mail ou senha inválidos!"));
        
    }

?>