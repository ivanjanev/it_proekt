<%@ Page Title="Oglasnik.mk" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="Category.aspx.cs" Inherits="Category" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-lg-12 text-center">
            <h2>Adverts in <asp:Label CssClass="advertCat" runat="server" ID="catLBL"></asp:Label> sector</h2>
            <hr />
        </div>
    </div>
    <div class="row">
       <div class="index-content">
          <div class="container" id="oglasiPoKatDiv">
               
          </div>
       </div>
    </div>
</asp:Content>
