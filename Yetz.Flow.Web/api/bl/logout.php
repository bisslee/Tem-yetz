<?php
    include("../bl/tools.php");
   
    session_start();
    $_SESSION['email'] = null;
    $_SESSION['usuario'] = null;
    Redirect("/index.php");

?>