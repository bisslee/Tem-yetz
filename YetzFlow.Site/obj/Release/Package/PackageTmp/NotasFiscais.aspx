<%@ Page Title="" Language="C#" MasterPageFile="~/YetzFlow.Master" AutoEventWireup="true" CodeBehind="NotasFiscais.aspx.cs" Inherits="YetzFlow.Site.NotasFiscais" %>
<%@ MasterType virtualPath="~/YetzFlow.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-12 mb-5">
            <h1><%=NomePagina %></h1> 
            <div>
                <!--Indicadores-->
                <!--Info-->
                <a class="mr-lg-2" id="info" href="#">
                    <i class="fa fa-fw fa-info-circle text-dark"></i>
                    <span class="d-lg-none">Total</span>
                    <span class="badge badge-pill badge-dark"><%=TotalRegistros %></span>
                </a>
                <a class="mr-lg-5" id="New" href="PagadoresForm.aspx">
                    <i class="fa fa-fw fa-plus-circle text-primary"></i>
                    <span class="text-dark">Novo</span>
                </a>
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
                            <th data-field="numeroNota" data-valign="middle">No. Nota</th>
                            <th data-field="pagador" data-valign="middle">Pagador</th>
                            <th data-field="valorNota">Valor</th>
                            <th data-field="dataNota">Data </th>
                            <th data-field="statusNota">Status</th>
                            <th>Ações</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptEntity" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# DataBinder.Eval(Container.DataItem, "Numero") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "IdPagador") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "Valor") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "DataEmissao") %></td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "IdStatus") %></td>
                                    </td><td>&nbsp;</td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
