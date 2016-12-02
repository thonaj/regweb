<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modifycoursetime.aspx.cs" EnableEventValidation="false" Inherits="RegistrationWeb.Client.modifycoursetime" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
   <div>
      <div>
         <asp:Label runat="server" ID="changetimelabel" Text="Change Course Time"></asp:Label>
      </div>
      <div>
         <asp:Label runat="server" ID="startlabel" Text="Start Time [hh:mm:ss]"></asp:Label>
         <asp:TextBox runat="server" ID="starttextbox" Width="250"></asp:TextBox>
      </div>
      <div>
         <asp:Label runat="server" ID="stoplabel" Text="Stop Time  [hh:mm:ss]"></asp:Label>
         <asp:TextBox runat="server" ID="stoptextbox" Width="250"></asp:TextBox>
      </div>
      <div>
          <asp:GridView runat="server" ID="coursegrid" AutoGenerateColumns="false" OnRowCreated="coursegrid_RowCreated" OnSelectedIndexChanged="coursegrid_SelectedIndexChanged">
             <Columns>
              <asp:BoundField HeaderText="Course ID" DataField="AppId" ReadOnly="true" />
              <asp:BoundField HeaderText="Course Name" DataField="Name" />
              <asp:BoundField HeaderText="Course Department" DataField="courseDepartment" />
              <asp:BoundField HeaderText="Current Enrollment" DataField="currentEnrollment" />  
              <asp:BoundField HeaderText="Course Capacity" DataField="courseCapacity" />
              <asp:BoundField HeaderText="Start Time" DataField="startTime" />      
              <asp:BoundField HeaderText="End Time" DataField="endTime" />                          
            </Columns>
         </asp:GridView>
         <asp:Button runat="server" ID="changetimebutton" Text="Change Time" Width="150" OnClick="changetimebutton_Click" />
      </div>
   </div>
</asp:Content>
