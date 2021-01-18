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
echo " // e-mail:".$email;

$senhaFinal = NewPassword($conexao, $email);

if($senhaFinal!=null) {

    $message = "Sua nova senha:".$senhaFinal;
    $headers = "From: contato@biss.com.br" . "\r\n" .
"CC: bisslee@gmail.com";
    $to = "bisslee@gmail.com";
    $subject = "[Yetz Flow] Envio de nova Senha";


    $success = mail($to,$subject,$message,$headers);
    if (!$success) {
        $errorMessage = error_get_last()['message'];

        echo $errorMessage;
    }
    Redirect("/index.php?msg=".urlencode("Nova senha enviada ao seu e-mail."));
} else {

    Redirect("/index.php?msg=".urlencode("E-mail não encontrado!"));
}
?>