<!DOCTYPE html>
<html lang="pt-br">
<head>
    <!-- Required meta tags -->
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Yetz Flow</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="bibliotecas/bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="bibliotecas/font-awesome/css/font-awesome.min.css" />
    <link rel="stylesheet" href="css/sb-admin.min.css" />

    <link rel="icon" href="/favicon.ico" />
    <link rel="canonical" href="https://yetz.flow.biss.com.br/" />    
</head>
<body class="bg-dark">
    <div class="container">

        <div class="card card-login mx-auto mt-5" >
            <div class="card-header">Login</div>
            <div class="card-body">
                <form  action="home.php">
                    <div class="form-group">
                        <label for="email">Email</label>
                        <input type="email" class="form-control"name="email" id="email" placeholder="Digite seu email" />
                    </div>
                    <div class="form-group">
                        <label for="senha">Senha</label>
                        <input type="password" class="form-control"name="senha" id="senha"  placeholder="Digite sua senha" />
                    </div>
                    <button type="submit" class="btn btn-primary btn-block">Login</button>
                    <div class="text-center">
                        <a href="recuperarSenha.php" class="d-block small mt-3">Esqueci minha Senha</a>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="bibliotecas/jquery/jquery.min.js"></script>    
    <script src="bibliotecas/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="bibliotecas/jquer/jquery-easing/jquery.easing.min.js"></script>
</body>
</html>
