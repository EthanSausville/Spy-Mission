<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Spy_Missions.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Spy New Mission Form</h1>
            Spy Code Name <asp:TextBox ID="spyNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Mission Name:
            <asp:TextBox ID="missionTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Prior Mission:
            <asp:Calendar ID="priorMissionCal" runat="server"></asp:Calendar>
            <br />
            Start Date of Current Mission:<asp:Calendar ID="startDateCal" runat="server"></asp:Calendar>
            <br />
            Projected End Date of Current Mission:<asp:Calendar ID="endDateCal" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="assignMissionBtn" runat="server" OnClick="assignMissionBtn_Click" Text="Assign Mission" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
