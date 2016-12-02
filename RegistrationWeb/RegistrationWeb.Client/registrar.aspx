<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="RegistrationWeb.Client.registrar" MasterPageFile="~/Site.Master" EnableEventValidation="false" %>


<asp:Content runat="server" ContentPlaceHolderID="body">
   <div id="content">

      <div>
       <asp:ListBox runat="server" ID="studentlist" ClientIDMode="Static" Width="15%"></asp:ListBox>
       <asp:ListBox runat="server" ID="courselist" ClientIDMode="Static" Width="50%"></asp:ListBox>
       <asp:ListBox runat="server" ID="studentcourselist" ClientIDMode="Static" Width="25%"></asp:ListBox>
      </div>


      <div>
       <asp:Button  ID="deleteStudentButton" Text="Delete Student" OnClick="deleteStudentButton_Click" runat="server" Width="15%"/>
       <asp:Button  ID="deleteCourseButton" Text="Delete Course" OnClick="deleteCourseButton_Click" runat="server" Width="15%"/>
       <asp:Button  ID="unregisterCourse" Text="Unregister Course" OnClick="unregisterCourse_Click" runat="server" Width="15%"/>       
       <asp:Button  ID="viewStudentSchedule" Text="View Student Schedule" OnClick="viewStudentSchedule_Click" runat="server" Width="15%" />          
       <asp:Button  ID="viewCourseEnrollment" Text="View Course Enrollment" OnClick="viewCourseEnrollment_Click" runat="server" Width="15%"/>
      </div>
      <div>
       <asp:Button  ID="addcoursebutton" Text="Add Course" OnClick="addcoursebutton_Click" runat="server" Width="20%"/>
       <asp:Button  ID="addstudentbutton" Text="Add Student" OnClick="addstudentbutton_Click" runat="server" Width="20%"/>
       <asp:Button  ID="modifycoursetime" Text="Go To Course Time Page" OnClick="modifycoursetime_Click" runat="server" Width="20%"/>
       <asp:Button  ID="modifycoursecapacity" Text="Go To Change Capacity Page" OnClick="modifycoursecapacity_Click" runat="server" Width="20%"/>
      </div>
      
      <div>
         
         <asp:GridView runat="server" ID="grid" AutoGenerateColumns="false"  OnRowDataBound="grid_RowDataBound" OnRowCreated="grid_RowCreated" OnSelectedIndexChanged="grid_SelectedIndexChanged" >
            <Columns>
              <asp:BoundField HeaderText="ID" DataField="AppId" ReadOnly="true" />
              <asp:BoundField HeaderText="First Name" DataField="firstName" />
              <asp:BoundField HeaderText="Last Name" DataField="lastName" />
              <asp:BoundField HeaderText="Major" DataField="major" />              
            </Columns>
         </asp:GridView>
         <asp:GridView runat="server" ID="coursegrid" AutoGenerateColumns="false" OnRowDataBound="coursegrid_RowDataBound" OnRowCreated="coursegrid_RowCreated" OnSelectedIndexChanged="coursegrid_SelectedIndexChanged">
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
         <asp:GridView runat="server" ID="sclgrid" AutoGenerateColumns="false" OnRowDataBound="sclgrid_RowDataBound" OnRowCreated="sclgrid_RowCreated" OnSelectedIndexChanged="sclgrid_SelectedIndexChanged">
             <Columns>
              <asp:BoundField HeaderText="Enrollment ID" DataField="AppId" ReadOnly="true" />
              <asp:BoundField HeaderText="Enrollment Name" DataField="Name" />
              <asp:BoundField HeaderText="Student Id" DataField="StudentID" />    
              <asp:BoundField HeaderText="Course Id" DataField="courseID" />                           
                                     
            </Columns>
         </asp:GridView>

         
      </div>
   </div>
</asp:Content>
