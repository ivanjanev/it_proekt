<%@ Page Title="Oglasnik.mk" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="addAdvert.aspx.cs" Inherits="addAdvert" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:LoginView runat="server" ViewStateMode="Disabled">
            <AnonymousTemplate>
                <div class="col-lg-12 text-center">
                    <h2>Please login before posting</h2>
                </div>
            </AnonymousTemplate>
            <LoggedInTemplate>
            <div class="col-lg-12 text-center">
            <h2>Add Advert</h2>
            <hr />
            <div class="row">
                <div class="col-lg-6 col-lg-offset-3">
                    <form action="#" method="post">
                        <div class="form-group">
                            <label for="companyInput">Company name:</label>
                            <input type="text" class="form-control addAdvertForm" id="companyInput" required>
                        </div>
                        <div class="form-group">
                            <label for="titleInput">Advert Title:</label>
                            <input type="text" class="form-control addAdvertForm" id="titleInput" required>
                        </div>
                        <div class="form-group">
                            <label for="categoryInput">Select Category:</label>
                            <select class="form-control addAdvertForm" id="categoryInput">
                                <option>IT Sector</option>
                                <option>Economy Sector</option>
                                <option>Law Sector</option>
                            </select
                        </div>
                        <div class="form-group">
                            <label for="descriptionInput">Description:</label>
                            <textarea class="form-control addAdvertForm" id="descriptionInput" required></textarea>
                        </div>
                        <div class="form-group">
                            <label for="fromDateInput">Valid from:</label>
                            <input type="date" class="form-control addAdvertForm" id="fromDateInput" required/>
                        </div>
                        <div class="form-group">
                            <label for="toDateInput">Valid to:</label>
                            <input type="date" class="form-control addAdvertForm" id="toDateInput" required/>
                        </div>
                        <button type="submit" class="btn btn-primary" id="submitAdvert">Submit</button>
                    </form>
                </div>
            </div>
        </div>
        </LoggedInTemplate>
        </asp:LoginView>
    </div>
</asp:Content>