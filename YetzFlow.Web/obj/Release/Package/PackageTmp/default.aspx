﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="YetzFlow.Web._default" %>

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
                <div class="card-header">Login</div>
                <div class="card-body">

                    <asp:Label ID="LblMensagemDeErro" class="alert-danger" runat="server" Visible="false" Text=""></asp:Label>

                    <div class="form-group">
                        <label for="email">Email</label>
                        <asp:TextBox ID="TxtEmail" runat="server" class="form-control" name="email" TextMode="Email" placeholder="Digite seu email" />
                    </div>
                    <div class="form-group">
                        <label for="senha">Senha</label>
                        <asp:TextBox ID="TxtSenha" runat="server" class="form-control" name="senha" TextMode="Password" />
                    </div>
                    <asp:Button ID="BtLogin" class="btn btn-primary btn-block" runat="server" Text="Login" />

                    <div class="text-center">
                        <a href="recuperarSenha.aspx" class="d-block small mt-3">Esqueci minha Senha</a>
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

