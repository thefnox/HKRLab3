<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebRole2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Grade info for University of KnowledgeBridge</h1>
        <div>
            <h3>Add Student</h3>
            <div>
                <p>Student ID</p>
                <asp:TextBox runat="server" ID="create_StudentID" />
            </div>
            <div>
                <p>Course Number</p>
                <asp:TextBox runat="server" ID="create_CourseNumber" />
            </div>
            <div>
                <p>Course Title</p>
                <asp:TextBox runat="server" ID="create_CourseTitle" />
            </div>
            <div>
                <p>HP</p>
                <asp:TextBox runat="server" ID="create_HP" />
            </div>
            <div>
                <p>Course Period</p>
                <asp:TextBox runat="server" ID="create_CoursePeriod" />
            </div>
            <div>
                <p>Student Name</p>
                <asp:TextBox runat="server" ID="create_StudentName" />
            </div>
            <div>
                <p>Email</p>
                <asp:TextBox runat="server" ID="create_Email" />
            </div>
            <div>
                <p>Grade</p>
                <asp:TextBox runat="server" ID="create_Grade" />
            </div>
            <asp:Label runat="server" ID="create_Error"></asp:Label>
            <asp:button runat="server" OnClick="Create" Text="Create"/>
        </div>
        <div>
            <h3>Edit Student</h3>
            <div>
                <p>Student ID</p>
                <asp:TextBox runat="server" ID="edit_StudentID" />
            </div>
            <div>
                <p>Course Number</p>
                <asp:TextBox runat="server" ID="edit_CourseNumber" />
            </div>
            <div>
                <p>Grade</p>
                <asp:TextBox runat="server" ID="edit_Grade" />
            </div>
            <div>
                <p>Email</p>
                <asp:TextBox runat="server" ID="edit_Email" />
            </div>
            <asp:Label runat="server" ID="edit_Error"></asp:Label>
            <asp:button runat="server" OnClick="Edit" Text="Edit"/>
        </div>
        <div>
            <h3>Count Courses</h3>
            <div>
                <p>Student ID</p>
                <asp:TextBox runat="server" ID="count_StudentID" />
            </div>
            <asp:Label runat="server" ID="count_Error"></asp:Label>
            <asp:button runat="server" OnClick="Count" Text="Count"/>
        </div>
        <div>
            <h3>Delete Student</h3>
            <div>
                <p>Student ID</p>
                <asp:TextBox runat="server" ID="delete_StudentID" />
            </div>
            <div>
                <p>Course name</p>
                <asp:TextBox runat="server" ID="delete_CourseName" />
            </div>
            <asp:Label runat="server" ID="delete_Error"></asp:Label>
            <asp:button runat="server" OnClick="Delete" Text="Delete"/>
        </div>
    </form>
</body>
</html>
