<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeDelete.aspx.cs" Inherits="WebApplication2.UI.EmployeeDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Delete Employee</h1>
    <h3>Are you sure?</h3>
    <asp:HiddenField ID="hidId" runat="server" />
    <dl class="dl-horizontal">
		<dt>
	        Last name
		</dt>
		<dd>
            <asp:Label ID="lblLastName" runat="server" ></asp:Label>
		</dd>
        <dt>
	        First name
		</dt>
		<dd>
            <asp:Label ID="lblFirstName" runat="server"></asp:Label>
		</dd>
        <dt>
	        Phone
		</dt>
		<dd>
            <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
		</dd>
        <dt>
	        Zip
		</dt>
		<dd>
            <asp:Label ID="lblZip" runat="server" Text="Label"></asp:Label>
		</dd>
        <dt>
	        Hire date
		</dt>
		<dd>
            <asp:Label ID="lblHireDate" runat="server" Text="Label"></asp:Label>
		</dd>
	</dl>
    <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn " OnClick ="btnCancel_Click" />
</asp:Content>
