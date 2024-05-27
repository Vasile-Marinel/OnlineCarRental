<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineCarRental.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Libraries/css/bootstrap.min.css"/>
</head>
<body>
    <style>
    body {
        background-image: url('../Assets/Img/back3.jpg');
        background-size: cover; /* pentru a asigura că imaginea acoperă întreaga pagină */
    }
</style>


    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-5">
                <div class="row mt-5">
                    <div class="col"></div>
                    <div class="col">
                        <h3 class="text-warning">Car Rental Login</h3>
                        <img src="../Assets/Img/orange_jeep.png" width="300"/>
                    </div>
                    <div class="col"></div>
                </div>
                <form runat="server">
                    <div class="form-group" runat="server">

                    <label for="exampleInputEmail1">Username</label>
                    <input type="text" class="form-control" id="UserNameTb" aria-describedby="emailHelp" placeholder="Enter Username" runat="server"/>
                    <small id="emailHelp" class="form-text text-muted">We'll never share your personal information.</small>
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">Password</label>
                    <input type="password" class="form-control" id="PasswordTb" placeholder="Password" runat="server"/>
                </div>
                <div class="form-group">
                    <input type="radio" class="form-check-input" id="CustRadio" name="Role" runat="server" />
                    <label class="form-check-label" for="exampleCheck1">Customer</label>
                    <input type="radio" class="form-check-input" id="AdminRadio" name="Role" runat="server" />
                    <label class="form-check-label" for="exampleCheck1">Admin</label>
                </div>

                    <label id="InfoMsg" runat="server" class="text-danger">
                    
                    </label>
                    <br />

                <br />
                    <asp:Button type="submit" id="SaveBtn" class="btn btn-warning btn-block" Text="Login" runat="server" OnClick="SaveBtn_Click" Width="356px"/>

                    <asp:Button type="submit" id="SignUpBtn" class="btn btn-light btn-block" Text="Sign up" runat="server" Width="356px" OnClick="SignUpBtn_Click"/>

                <div class="form-group d-grid">
                </div>
                </form>
            </div>
            <div class="col-md-3"></div>
        </div>
    </div>
</body>
</html>
