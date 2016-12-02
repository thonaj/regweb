<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="modifycoursecapacity.aspx.cs" Inherits="RegistrationWeb.Client.modifycoursecapacity" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
   <div>
      <div>
         <asp:Label runat="server" ID="changecapacitylabel" Text="Change Course Capacity"></asp:Label>
      </div>
      <div>
         <asp:Label runat="server" ID="capacitylabel" Text="New Capacity"></asp:Label>
         <asp:TextBox runat="server" ID="capacitytextbox" Width="250"></asp:TextBox>
      </div>
      
      <div>
          <asp:GridView runat="server" ID="coursegrid" AutoGenerateColumns="false" OnRowCreated="coursegrid_RowCreated"  OnSelectedIndexChanged="coursegrid_SelectedIndexChanged">
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
         <asp:Button runat="server" ID="changecapacitybutton" Text="Change Capacity" Width="150"  OnClick="changecapacitybutton_Click" />
      </div>
   </div>
</asp:Content>