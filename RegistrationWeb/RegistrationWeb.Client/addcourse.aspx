<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addcourse.aspx.cs" Inherits="RegistrationWeb.Client.addcourse"  MasterPageFile="~/Site.Master"%>

<asp:Content runat="server" ContentPlaceHolderID="body">
   <div id="content">
      <div>
         <asp:Label runat="server" ID="addcourselabel" Text="Add Course"></asp:Label>
      </div>
      <div>
         <asp:Label runat="server" ID="namelabel" Text="Name"></asp:Label>
         <asp:TextBox runat="server" ID="namebox" Width="250"></asp:TextBox>
         <asp:Label runat="server" ID="deptlabel" Text="Department"></asp:Label>
         <asp:TextBox runat="server" ID="deptbox" Width="250"></asp:TextBox>
         <asp:Label runat="server" ID="capacitylabel" Text="Capacity"></asp:Label>
         <asp:TextBox runat="server" ID="capacitybox" Width="250"></asp:TextBox>
         <asp:Label runat="server" ID="proflabel" Text="Professor"></asp:Label>
         <asp:TextBox runat="server" ID="profbox" Width="250"></asp:TextBox>
         <asp:Label runat="server" ID="cred" Text="Credits"></asp:Label>
         <asp:TextBox runat="server" ID="credtext" Width="50"></asp:TextBox>
      </div>
      <div>
         <asp:Label runat="server" ID="start1" Text="Start Time Hours"></asp:Label>
         <asp:TextBox runat="server" ID="start1box" Width="50"></asp:TextBox>
         <asp:Label runat="server" ID="start2" Text="Min"></asp:Label>
         <asp:TextBox runat="server" ID="start2box" Width="50"></asp:TextBox>
         <asp:Label runat="server" ID="start3" Text="Sec"></asp:Label>
         <asp:TextBox runat="server" ID="start3box" Width="50"></asp:TextBox>
      </div>
      <div>         
         <asp:Label runat="server" ID="end1" Text="End Time Hours"></asp:Label>
         <asp:TextBox runat="server" ID="end1box" Width="50"></asp:TextBox>
         <asp:Label runat="server" ID="end2" Text="Min"></asp:Label>
         <asp:TextBox runat="server" ID="end2box" Width="50"></asp:TextBox>
         <asp:Label runat="server" ID="end3" Text="Sec"></asp:Label>
         <asp:TextBox runat="server" ID="end3box" Width="50"></asp:TextBox>
      </div>
      <div>         
         <asp:Button runat="server" ID="addcoursebutton" Text="Add Course"  OnClick="addcoursebutton_Click"/>
      </div>
   </div>
</asp:Content>
