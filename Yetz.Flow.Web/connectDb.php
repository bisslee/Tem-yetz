<?php

$servername='bd.asp.hostazul.com.br';
$database='9263_yetz.flow';
$username='9263_yetzflow';
$password='yetzflow2306';
$port =4406;

$conexao = mysqli_connect($servername,$username ,$password ,$database ,$port);
if (mysqli_connect_errno())
{
    echo "Failed to connect to MySQLss: " . mysqli_connect_error();
}
else{
    echo "Connect to MySQL Sucess!";
}