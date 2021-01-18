<%@ Page Title="" Language="C#" MasterPageFile="~/YetzFlow.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="YetzFlow.Site.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-12 mb-5">
            <h1><%=NomePagina %></h1>
        </div>
    </div>
    <div class="row">
        <div class="col-xl-3 col-sm-6 mb-3">
            <!--Indicadores-->
            <div class="card text-white bg-dark o-hidden h-100">
                <div class="card-header">
                    <div class="card-body-icon">
                        <i class="fa fa-fw fa-money"></i>
                    </div>
                    <div class="mr-5">
                        <h6><asp:Label ID="LblTituloIndicador" runat="server" Text="Título Indicador"></asp:Label></h6>
                    </div>
                </div>
                <div class="card-body bg-secondary">
                    <div>
                        <a class="nav-link  mr-lg-2" id="info" href="#">
                            <i class="fa fa-fw fa-info-circle"></i>
                            <span class="d-lg-none">Total</span>
                            <span class="badge badge-pill badge-secondary">
                                <asp:Label ID="LblTotalInfo" runat="server" Text="222"></asp:Label></span>
                        </a>
                    </div>
                    
                </div>
                <asp:HyperLink ID="HlnkIndicadoresPage" CssClass="card-footer text-white clear-fix small z-1" runat="server" Text="IndicadoresPage">                       
                    <span class="float-left"> ir para página</span>
                    <span class="float-rigth"><i class="fa fa-angle-right"></i></span>
                </asp:HyperLink>
            </div>
        </div>
    </div>
</asp:Content>
