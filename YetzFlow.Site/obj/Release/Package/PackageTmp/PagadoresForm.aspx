<%@ Page Title="" Language="C#" MasterPageFile="~/YetzFlow.Master" AutoEventWireup="true" CodeBehind="PagadoresForm.aspx.cs" Inherits="YetzFlow.Site.PagadoresForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-12 mb-5">
            <h1><%=NomePagina %></h1>
        </div>
    </div>
    <div class="row">
        <div class="col-12">
            <!--Form-->
            <div class="col-10 mb-5">
                <div class="card text-white bg-dark o-hidden h-100">
                    <div class="card-header">
                        <div class="mr-2">
                            <h4>
                                <i class="fa fa-fw fa-money"></i>&nbsp; <%=NomePagina %>
                            </h4>
                        </div>
                    </div>
                    <div class="card-body bg-light text-dark">
                        <div class="row">
                            <div class="col-md-9">
                                <asp:HiddenField ID="hndID" runat="server" />
                                <label for="nomePagador">Nome</label>
                                <asp:TextBox CssClass="form-control"  name="nomePagador" MaxLength="150" ID="nomePagador" placeholder="Digite o nome do pagador" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label for="cnpjPagador">CNPJ</label>
                                <asp:TextBox CssClass="form-control" name="cnpjPagador"  MaxLength="14" ID="cnpjPagador" placeholder="Digite o CNPJ do pagador" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-9">
                                <label for="emailPagador">Email</label>
                                <asp:TextBox CssClass="form-control" name="emailPagador"  MaxLength="150" ID="emailPagador" placeholder="Digite o email do pagador" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label for="telefonePagador">Telefone</label>
                                <asp:TextBox CssClass="form-control" name="telefonePagador"  MaxLength="20" ID="telefonePagador" placeholder="Digite o telefone do pagador" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-9">
                                <label for="contatoPagador">Contato</label>
                                <asp:TextBox CssClass="form-control" name="contatoPagador"  MaxLength="150" ID="contatoPagador" placeholder="Digite o nome do contato" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <label for="contatoCelular">Celular</label>
                                <asp:TextBox CssClass="form-control" name="contatoCelular"  MaxLength="20" ID="contatoCelular" placeholder="Digite o celular do contato" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="card-footer bg-dark pull-right">                      
                        <asp:Button ID="BtSalvar" CssClass="btn btn-success"  runat="server" Text="Salvar" OnClick="BtSalvar_Click" />
                        <asp:Button ID="BtCancelar" CssClass="btn btn-danger"  runat="server" Text="Cancelar" OnClick="BtCancelar_Click" />
                    </div>

                </div>
            </div>
        </div>

    </div>

</asp:Content>
