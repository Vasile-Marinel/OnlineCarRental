<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="PendingRentals.aspx.cs" Inherits="OnlineCarRental.View.Customer.PendingRentals" %>

<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col"></div>
            <div class="col">
                <h2 class="text-warning">Your Pending Rentals</h2>
            </div>
            <div class="col"></div>
        </div>
        <div class="row">
           <div class="col-lg-2"></div>
           <div class="col-12">
                <form runat="server">
                    <div class="col-md-8">
                        
                <asp:GridView runat="server" ID="PendingList" Class="table table-hover table-warning" Width="936px" PageSize="6" AutoGenerateSelectButton="true">
                    
                </asp:GridView>
                        <label id="InfoMsg" runat="server" class="text-danger">
                    </label>
                        <br />
                <asp:Button type="submit" id="DeleteBtn" class="btn btn-danger btn-block" Text="Cancel the rental" runat="server" Width="356px" OnClick="DeleteBtn_Click"/>
            </div>
                </form>
            </div>
            <div class="col-lg-2"></div>

        </div>
    </div>
</asp:Content>
