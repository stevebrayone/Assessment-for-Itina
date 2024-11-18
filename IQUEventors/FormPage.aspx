<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormPage.aspx.cs" Inherits="IQUEventors.FormPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Form Submission</title>
    <style>
        body {
            outline: black double 20px;
            padding: 50px;
            overflow:scroll;
        }
        #signature-pad {
            border: 1px solid #000;
            width: 100%;
            height: 200px;
            color:aquamarine;
        }
        form {
             border-style: dotted solid;
             border-width: medium;
             border-color: bisque;
             border-radius: 5px;
            }
        button:hover {
            background-color: black;
            color: aquamarine;
        }
        #submit:hover{
            background-color: black;
            color: aquamarine;
        }

    </style>
</head>
<body>
     <h2>Submit Your Information</h2>
    <form id="form" runat="server">
        <label for="name">Name:</label>
        <input type="text" id="name" runat="server" required /><br />

        <label for="email">Email:</label>
        <input type="email" id="email" runat="server" required /><br />

        <label for="phone">Phone Number:</label>
        <input type="tel" id="phone" runat="server" required /><br />

        <label for="signature">Signature:</label>
        <canvas id="Canvas1" runat="server"></canvas><br />
        <button type="button" onclick="clearSignature()">Clear Signature</button><br />

        <input type="submit" value="Submit" id="submit" />
    </form>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/signature_pad/1.0.0/signature_pad.min.js"></script>
    <script>
        const canvas = document.getElementById("signature-pad");
        const signaturePad = new SignaturePad(canvas);
        function clearSignature() {
            signaturePad.clear();
        }
        document.getElementById("form").onsubmit = function (e) {
            if (!signaturePad.isEmpty()) {
                const signatureData = signaturePad.toDataURL();
                document.getElementById("signatureData").value = signatureData; 
            } else {
                alert("Please provide a signature.");
                e.preventDefault(); 
            }
        };
    </script>

    <input type="hidden" id="signatureData" runat="server" />
    </body>
</html>
