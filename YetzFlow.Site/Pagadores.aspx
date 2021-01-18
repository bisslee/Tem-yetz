<%@ Page Title="" Language="C#" MasterPageFile="~/YetzFlow.Master" AutoEventWireup="true" CodeBehind="Pagadores.aspx.cs" Inherits="YetzFlow.Site.Pagadores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-12 mb-5">
            <h1><%=NomePagina %></h1>
            <div>
                <!--Indicadores-->
                <!--Info-->
                <div>
                    <asp:Image ID="ImgInfo" ImageUrl="~/img/info.png" Height="20px" runat="server" />
                    <span class="mr-lg-2  text-dark"><%=TotalRegistros %></span>                
                    <a id="New" class="mr-lg-2"  href="PagadoresForm.aspx">
                        <asp:Image ID="imgNovo" ImageUrl="~/img/add.png" Height="20px" runat="server" />
                        <span class="text-dark">Novo</span>
                    </a>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-12">
            <!--Table-->
            <div class="col-10 mb-5">
                <table data-toggle="table" data-search="true" data-show-columns="true">
                    <thead>
                        <tr class="tr-class-1">
                            <th data-field="nome" data-valign="middle">Nome</th>
                            <th data-field="cnpj">CNPJ</th>
                            <th data-field="contato">Contato</th>
                            <th data-field="telefone">Telefone</th>
                            <th>&nbsp;</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptEntity" runat="server" OnItemDataBound="rptEntity_ItemDataBound" OnItemCommand="rptEntity_ItemCommand" >
                            <ItemTemplate>
                                <tr>
                                    <td><%# DataBinder.Eval(Container.DataItem, "Nome") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "CNPJ") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "Contato") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "Telefone") %></td>
                                    <td>
                                        &nbsp;<asp:ImageButton ID="BtEdit" CommandName="edit" AlternateText="Alterar <%=NomePagina %>" ImageUrl="~/img/edit.png" Height="17px" runat="server" />
                                        &nbsp;
                                        <asp:ImageButton ID="BtDelete" CommandName="delete" AlternateText="Apagar <%=NomePagina %>" ImageUrl="~/img/cancel.png" Height="17px" runat="server" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
