<?php


$dominio = $_SERVER['HTTP_HOST'];
echo " // dominio:".$dominio;

if ((strrpos($dominio,"localhost")>=-1) ||(strrpos($dominio,"biss")>=-1))
{
    /* Servidor Biss*/
    $servername='bd.asp.hostazul.com.br';
    $database='9263_yetz.flow';
    $username='9263_yetzflow';
    $password='yetzflow2306';
    $port =4406;
}
else
{
    /* Servidor Yetz*/
    $servername='162.241.2.62';
    $database='yetzfl02_db';
    $username='yetzfl02_us';
    $password='yetzflow2306';
    $port =3306;
     
}

$conexao = mysqli_connect($servername,$username ,$password ,$database ,$port);
if (mysqli_connect_errno())
{
    echo "Failed to connect to MySQLss: " . mysqli_connect_error();
}
else{
    echo "Connect to MySQL Sucess!";
}
?>