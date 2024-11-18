<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuccessPage.aspx.cs" Inherits="IQUEventors.SuccessPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Submission Success</title>
</head>
<body>
    <h2>Form Submitted Successfully</h2>

    <p><strong>Name:</strong> <%= Request.QueryString["name"] %></p>
    <p><strong>Email:</strong> <%= Request.QueryString["email"] %></p>
    <p><strong>Phone Number:</strong> <%= Request.QueryString["phone"] %></p>

    <h3>Signature:</h3>
    <img src="<%= Request.QueryString["signature"] %>" alt="User Signature" />
</body>
</html>
