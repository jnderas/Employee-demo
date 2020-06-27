<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET Example code</h1>
        <p class="lead">Welcome to my ASP example code</p>
        <p>This code was built using ASP WebFoms, Bootstrap, Jquery and SQL Server</p>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>Readme</h2>
            <p>
                This proyect it is a Employee crud demo.
            </p>
            <p>
                To navigate use de menu above
            </p>
            
        </div>
        <div class="col-md-6 alert alert-dismissible alert-info">
            <h2>Important</h2>
            <p>
                Before you start you must run the database script and config the conecction string in the web.config file
            </p>
        </div>
       
    </div>

</asp:Content>
