<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="RegistrationWeb.Client.student" MasterPageFile="~/Site.Master" EnableEventValidation="false" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
   <div id="content">
      <div>
         <asp:Label runat="server" ID="studentlabel" ></asp:Label>
      </div>
      <div>
          <asp:GridView runat="server" ID="grid" AutoGenerateColumns="false" OnRowCreated="grid_RowCreated" OnSelectedIndexChanged="grid_SelectedIndexChanged" >
            <Columns>
              <asp:BoundField HeaderText="ID" DataField="AppId" ReadOnly="true" />
              <asp:BoundField HeaderText="First Name" DataField="firstName" />
              <asp:BoundField HeaderText="Last Name" DataField="lastName" />
              <asp:BoundField HeaderText="Major" DataField="major" />              
            </Columns>
         </asp:GridView>
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

      </div>
      <div>
         <asp:Button runat="server" ID="registerbutton" Text="Register" OnClick="registerbutton_Click" />
         <asp:Button runat="server" ID="dropbutton" Text="Drop Course" OnClick="dropbutton_Click" />
         <asp:Button runat="server" ID="addtocartbutton" Text="Add to Cart" OnClick="addtocartbutton_Click" />
      </div>
      <div>
         <asp:GridView runat="server" ID="sclgrid" AutoGenerateColumns="false" OnRowCreated="sclgrid_RowCreated" OnSelectedIndexChanged="sclgrid_SelectedIndexChanged">
             <Columns>
              <asp:BoundField HeaderText="Enrollment ID" DataField="AppId" ReadOnly="true" />
              <asp:BoundField HeaderText="Enrollment Name" DataField="Name" />
              <asp:BoundField HeaderText="Student Id" DataField="StudentID" />    
              <asp:BoundField HeaderText="Course Id" DataField="courseID" />                           
                                     
            </Columns>
         </asp:GridView>

      </div>
      <div>
         <asp:datalist runat="server" ID="cartlist" ClientIDMode="Static" Width="15%"></asp:datalist>
      </div>
   </div>
</asp:Content>
