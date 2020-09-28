<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Icthmw.ui.error._Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body{
            margin:0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <h1 runat="server" id="title"></h1>
            <hr/>
            <label>nginx</label>
            <div style="text-align:left;margin-left:20px">
                 <label runat="server" id="conten"></label>
            </div>
        </div>
    </form>
</body>
</html>
