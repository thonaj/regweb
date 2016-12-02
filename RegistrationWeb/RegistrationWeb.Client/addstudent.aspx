<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addstudent.aspx.cs" Inherits="RegistrationWeb.Client.addstudent" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
   <div id="content">
      <div>
         <asp:Label runat="server" ID="addstudentlabel" Text="Add Student"></asp:Label>
      </div>
      <div>
         <asp:Label runat="server" ID="firstlabel" Text="First Name"></asp:Label>
         <asp:TextBox runat="server" ID="firstbox" Width="250"></asp:TextBox>
         <asp:Label runat="server" ID="middlelabel" Text="Middle Name"></asp:Label>
         <asp:TextBox runat="server" ID="middlebox" Width="250"></asp:TextBox>
         <asp:Label runat="server" ID="lastlabel" Text="Last Name"></asp:Label>
         <asp:TextBox runat="server" ID="lastbox" Width="250"></asp:TextBox>
         <asp:Label runat="server" ID="majorlabel" Text="Major"></asp:Label>
         <asp:TextBox runat="server" ID="majorbox" Width="250"></asp:TextBox>
         <asp:Button runat="server" ID="addstudentbutton" Text="Add Student"  OnClick="addstudentbutton_Click"/>
      </div>
   </div>
</asp:Content>
