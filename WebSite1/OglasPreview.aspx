<%@ Page Title="Oglasnik.mk" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="OglasPreview.aspx.cs" Inherits="OglasPreview" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-lg-12 text-center">
            <h2 id="oglasN">Advert #<asp:Label CssClass="brOglas" runat="server" ID="numberLBL"></asp:Label></h2>
            <hr />
        </div>
    </div>
    <div class="row">
            <div class="col-lg-8 col-lg-offset-2 text-center">
                <h3 id="title"></h3>
                <hr>
                <div class="row">
                    <div class="col-lg-6 text-left advertRows">
                        <p><span class="glyphicon glyphicon-briefcase"></span> <b>Company:</b></p>
                    </div>
                    <div class="col-lg-6 text-left advertRows">
                        <p id="company"></p>
                    </div>
                </div>
                <hr>
                <div class="row">
                    <div class="col-lg-6 text-left advertRows">
                        <p><span class="glyphicon glyphicon-tag"></span> <b>Category:</b></p>
                    </div>
                    <div class="col-lg-6 text-left advertRows">
                        <p id="category"></p>
                    </div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-lg-6 text-left advertRows">
                        <p><span class="glyphicon glyphicon-th-list"></span> <b>Description:</b></p>
                    </div>
                    <div class="col-lg-6 text-left text-justified advertRows">
                        <p id="description"></p>
                    </div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-lg-6 text-left advertRows">
                        <p><span class="glyphicon glyphicon-calendar"></span> <b>Valid from:</b></p>
                    </div>
                    <div class="col-lg-6 text-left advertRows">
                        <p id="fromDate"></p>
                    </div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-lg-6  text-left advertRows">
                        <p><span class="glyphicon glyphicon-calendar"></span> <b>Valid to:</b></p>
                    </div>
                    <div class="col-lg-6 text-left advertRows">
                        <p id="toDate"></p>
                    </div>
                    <hr />
                </div>
                <div class="row">
                    <button class="btn btn-danger pull-right" style="width:150px">Apply</button>
                </div>
            </div>
        </div>
</asp:Content>
