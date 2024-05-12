<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="OnlineCarRental.View.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Libraries/css/bootstrap.min.css"/>
</head>
<body>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col-lg-5"></div>
                    <div class="col-lg-5">
                        <h3 class="text-danger pl-4">SignUp</h3>
                        <img src="../Assets/Img/signUp.png" height="130px"/></div>
                    <div class="col-lg-3"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <form runat="server">
                            <div class="form-group">
                              <label for="exampleInputEmail1">Full Name</label>
                              <input type="text" class="form-control" id="FullNameTb" placeholder="Enter Full Name" runat="server" required="required"/>
                              
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Address</label>
                                <input type="text" class="form-control" id="SignAddTb" placeholder="Enter Address" runat="server" required="required"/>
                                
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Phone</label>
                                <input type="text" class="form-control" id="SignPhoneTb" placeholder="Enter Phone" runat="server" required="required"/>
                                
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail1">Password</label>
                                <input type="password" class="form-control" id="SignPassTb" placeholder="Enter Password" runat="server" required="required"/>
                                
                            </div>
                            
                            <br />

                            <label id="ErrorMsg" runat="server" class="text-danger"></label><br />
                            <asp:Button type="submit" id="ContinueBtn" class="btn btn-warning btn-block" Text="Continue" runat="server" Width="356px"  OnClick="ContinueBtn_Click"/>

                          </form>

                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
