<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="RegistrationWeb.Client._default" MasterPageFile="~/Site.Master" EnableEventValidation="false" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
   <div>
         <asp:GridView runat="server" ID="grid" AutoGenerateColumns="false"  OnRowCreated="grid_RowCreated" OnSelectedIndexChanged="grid_SelectedIndexChanged" >
           <Columns>
              <asp:BoundField HeaderText="ID" DataField="AppId" ReadOnly="true" />
              <asp:BoundField HeaderText="First Name" DataField="firstName" />
              <asp:BoundField HeaderText="Last Name" DataField="lastName" />
              <asp:BoundField HeaderText="Major" DataField="major" />              
            </Columns>
         </asp:GridView>
   </div>
   <div>
      <asp:Button runat="server" ID="selectbutton" Text="Log In"  OnClick="selectbutton_Click"/>
   </div>
</asp:Content>


   

