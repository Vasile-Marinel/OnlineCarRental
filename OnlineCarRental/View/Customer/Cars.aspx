<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="OnlineCarRental.View.Customer.Cars" %>

<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-10"></div>

            <div class="col-md-2">
                <label id="CustName" class="text-warning" runat="server">xxxxx</label>
            </div>

        </div>
        <div class="row">
            <div class="col-md-5"></div>
            <div class="col-md-4 ml-5"><img src="../../Assets/Img/available_car.png"/></div>
            <div class="col-md-4">

            </div>

        </div>
       
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col">
                <form runat="server">
                    <div class="col-md-8">
                        <div class="row"><div class="col-4"></div><div><h1 class="text-warning">Available Cars</h1></div></div>
                <asp:GridView runat="server" ID="CarList" Class="table table-hover table-warning" AutoGenerateSelectButton="True" Width="936px" PageSize="6">
                    
                </asp:GridView>
            </div>
                    <div class="row">
                        <div class="col-4">
                            <div class="form-group">
                    
                    <input type="date" class="form-control" id="ReturnDate" placeholder="Password" runat="server" required="required">
                </div>
                        </div>
                        <div class="col-4">
                            <div class="form-group d-grid">
                        <label id="InfoMsg" runat="server" class="text-danger"></label>
                    <asp:Button type="submit" id="BookBtn" class="btn btn-warning btn-block" Text="Book" runat="server" OnClick="BookBtn_Click"/>
                </div>
                        </div>
                    </div>
                </form>
                
            </div>
        </div>
    </div>
</asp:Content>
