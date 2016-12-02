<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewstudentschedule.aspx.cs" Inherits="RegistrationWeb.Client.viewstudentschedule"  MasterPageFile="~/Site.Master"%>

<asp:Content runat="server" ContentPlaceHolderID="body">
   <div id="content">
      <div>
         <asp:Label ID="studentname" runat="server"></asp:Label>
      </div>
       <asp:GridView runat="server" ID="courses" AutoGenerateColumns="false"  >
            <Columns>
              <asp:BoundField HeaderText="ID" DataField="AppId" ReadOnly="true" />
              <asp:BoundField HeaderText="Course Name" DataField="Name" />
              <asp:BoundField HeaderText="Course Department" DataField="courseDepartment" />
                          
            </Columns>
         </asp:GridView>
   </div>
</asp:Content>

