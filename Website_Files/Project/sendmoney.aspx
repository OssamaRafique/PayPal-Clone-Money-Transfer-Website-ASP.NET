<%@ Page Title="" Language="C#" MasterPageFile="~/loggedin.Master" AutoEventWireup="true" CodeBehind="sendmoney.aspx.cs" Inherits="Project.sendmoney" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
                <div class="col-md-12">
                    <div class="card">
					<div class="card-heading card-default">
                            Send Money
                        </div>
                        <div class="card-block">

                            <asp:Label ID="lblmsg" runat="server" Text="" class="lblerror"></asp:Label>
                            <div id="mtop" runat="server">
                            <div class="form-group">
                                <asp:TextBox ID="txtreceiver" runat="server" CssClass="form-control" placeholder="Enter Receiver Username"></asp:TextBox>
                                        <small class="text-muted">You can send money to a user by his/her username.</small>
                                </div>
                                                        <div class="form-group">
                                <asp:TextBox ID="txtamount" runat="server" CssClass="form-control" placeholder="Amount in PKR"></asp:TextBox>
                                </div>
                            <div class="form-group">
                                <asp:Button ID="btnsend" runat="server" Text="Send Money" CssClass="btn btn-md btn-indigo" OnClick="btnsend_Click" />
                                </div>
                                </div>
                            
                        </div>
                    </div>
                </div>
            </div>           
</asp:Content>
