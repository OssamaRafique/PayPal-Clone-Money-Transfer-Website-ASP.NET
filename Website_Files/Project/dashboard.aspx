<%@ Page Title="" Language="C#" MasterPageFile="~/loggedin.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="Project.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                                    <div class="row">
            
                <div class="col-md-4">
                    <div class="widget  bg-light">
                        <div class="row row-table ">
                                <h2 class="margin-b-5">Account Balance</h2>
                                <p class="text-muted">Available Balance </p>
                                <span id="lblbalance" runat="server" class="pull-right text-primary widget-r-m">0</span>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="widget  bg-light">
                        <div class="row row-table ">
                                <h2 class="margin-b-5">Transfers</h2>
                                <p class="text-muted">Total Transfers</p>
                                <span id="lbltransfers" runat="server" class="pull-right text-success widget-r-m">0 PKR</span>
                        </div>
                    </div>
                </div>
                
                <div class="col-md-4">
                    <div class="widget  bg-light">
                        <div class="row row-table ">
                                <h2 class="margin-b-5">Withdrawals</h2>
                                <p class="text-muted">Total Withdrawals</p>
                                <span id="lblwithdrawals" runat="server" class="pull-right text-warning widget-r-m">0 PKR</span>
                        </div>
                    </div>
                </div>
            </div>    
        <div class="row">
                <div class="col-md-12">
                  <div class="card">
                        <div class="card-heading card-default">
                            Recent Transactions
                        </div>
                        <div class="card-block">
                            <div>
                                <canvas id="linechart"  height="100"></canvas>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        
</asp:Content>
