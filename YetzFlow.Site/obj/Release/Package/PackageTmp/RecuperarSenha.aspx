<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarSenha.aspx.cs" Inherits="YetzFlow.Site.RecuperarSenha" %>

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
    <form id="form1" runat="server">

        <div class="container">
            <div class="card card-login mx-auto mt-5">
                <div class="card-header">Recuperar Senha</div>
                <div class="card-body">
                    <div class="text-center mt-2 mb-3">
                        <p>Digite seu e-mail que lhe enviaremos uma nova senha.</p>
                    </div>
                    <!--trocar-->

                    <div class="form-group">
                        <label for="email">Email</label>                        
                        <asp:TextBox runat="server" class="form-control" ID="TxtEmail" TextMode="Email"  placeholder="Digite seu email" />
                    </div>
                    <asp:Button ID="BtEnvia" class="btn btn-primary btn-block" runat="server" Text="Enviar" OnClick="BtEnvia_Click"  />
                    <div class="text-center">
                        <a href="default.aspx" class="d-block small mt-3">Voltar</a>
                        <asp:Label ID="LblMensagem" CssClass="alert-danger" Visible="false" runat="server" Text=""></asp:Label>
                    </div>
                    
                </div>
            </div>
        </div>
        <!-- Optional JavaScript -->
        <!-- jQuery first, then Popper.js, then Bootstrap JS -->
        <script src="bibliotecas/jquery/jquery.min.js"></script>
        <script src="bibliotecas/bootstrap/js/bootstrap.bundle.min.js"></script>
        <script src="bibliotecas/jquer/jquery-easing/jquery.easing.min.js"></script>
    </form>
</body>
</html>