<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewcourseenrollment.aspx.cs" Inherits="RegistrationWeb.Client.viewcourseenrollment"  MasterPageFile="~/Site.Master"%>

<asp:Content runat="server" ContentPlaceHolderID="body">
   <div id="content">
      <div>
         <asp:Label ID="courseName" runat="server"></asp:Label>
      </div>
       <asp:GridView runat="server" ID="enrolledstudents" AutoGenerateColumns="false"  >
            <Columns>
              <asp:BoundField HeaderText="ID" DataField="AppId" ReadOnly="true" />
              <asp:BoundField HeaderText="First Name" DataField="firstName" />
              <asp:BoundField HeaderText="Last Name" DataField="lastName" />
              <asp:BoundField HeaderText="Major" DataField="major" />      
                          
            </Columns>
         </asp:GridView>
   </div>
</asp:Content>
