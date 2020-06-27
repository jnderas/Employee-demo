<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeCreate.aspx.cs" Inherits="WebApplication2.UI.EmployeeCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>New Employee</h1>
    <asp:HiddenField ID="hidError" runat="server" />
    <% if (!string.IsNullOrEmpty(hidError.Value))
        {%>
    <div class="alert alert-dismissible alert-danger">
        <button type="button" class="close" data-dismiss="alert">&times;</button>
        <p>
            You must select a date
        </p>
    </div>
    <%} %>

    <dl class="dl-horizontal">
        <dt>            
            Last name
        </dt>
        <dd>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </dd>
        <dt>First name
        </dt>
        <dd>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </dd>
        <dt>Phone
        </dt>
        <dd>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        </dd>
        <dt>Zip
        </dt>
        <dd>
            <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
        </dd>
        <dt>Hire date
        </dt>
        <dd>
            <asp:Calendar ID="calHireDate"  runat="server" ></asp:Calendar>
        </dd>
    </dl>
    <asp:Button ID="btnSave"  OnClick="btnSave_Click" runat="server" Text="Save" CssClass="btn btn-primary"/>
    <asp:Button ID="btnCancel"  OnClick="btnCancel_Click" runat="server" Text="Cancel" CssClass="btn cla_cancelar"/>
    <script src="../Scripts/WebForms/EmployeeValidations.js"></script>

</asp:Content>

