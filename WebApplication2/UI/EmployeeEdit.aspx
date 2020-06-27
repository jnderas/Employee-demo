<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeEdit.aspx.cs" Inherits="WebApplication2.UI.EmployeeEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>New Employee</h1>
    <asp:HiddenField ID="hidId" runat="server" />
    <% if (Request["error"] != null)
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
        <dt>
	        First name
		</dt>
		<dd>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
		</dd>
        <dt>
	        Phone
		</dt>
		<dd>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
		</dd>
        <dt>
	        Zip
		</dt>
		<dd>
            <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
		</dd>
        <dt>
	        Hire date
		</dt>
		<dd>
            <asp:Calendar ID="calHireDate" runat="server"></asp:Calendar>
		</dd>
	</dl>
    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn cla_cancelar " OnClick ="btnCancel_Click" />

    <script src="../Scripts/WebForms/EmployeeValidations.js"></script>

</asp:Content>
