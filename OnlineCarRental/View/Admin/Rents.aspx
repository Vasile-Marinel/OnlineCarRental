<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Rents.aspx.cs" Inherits="OnlineCarRental.View.Admin.Rents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="row">
                    <div class="col-5"></div>
                    <div class="col-5">
                        <h3 class="text-danger pl-4">Rented Cars</h3>
                        <img src="../../Assets/Img/rented-car.png"/></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col-lg-2"></div>
                    <div class="col-lg-9">
                        <form runat="server">
                           <asp:GridView runat="server" ID="RentList" Class="table table-hover table-warning" Width="1418px" PageSize="6" AutoGenerateSelectButton="True" OnSelectedIndexChanged="RentList_SelectedIndexChanged">
                    
                           </asp:GridView>
                            <div class="form-group">
                    <input type="text" class="form-control" id="DelayTb" runat="server"/>
                    <label class="form-check-label" for="exampleCheck1">Delay</label>
                    <input type="text" class="form-control" id="FineTb" runat="server" />
                    <label class="form-check-label" for="exampleCheck1">Fine</label>
                </div>

                            <div class="form-group d-grid">
                    <label id="InfoMsg" runat="server" class="text-danger"></label>
                    <asp:Button type="submit" id="SaveBtn" class="btn btn-warning btn-block" Text="Return" runat="server" Width="1019px" OnClick="SaveBtn_Click"/>
                </div>
                          </form>
                    </div>


                </div>
            </div>
            <div class="col-md-8">
                <table class="table">
                    
                </table>
            </div>
        </div>
    </div>
</asp:Content>
