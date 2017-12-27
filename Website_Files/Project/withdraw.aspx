<%@ Page Title="" Language="C#" MasterPageFile="~/loggedin.Master" AutoEventWireup="true" CodeBehind="withdraw.aspx.cs" Inherits="Project.withdraw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
                <div class="col-md-12">
                    <div class="card">
					<div class="card-heading card-default">
                            Withdraw Money
                        </div>
                        <div class="card-block">

                            <asp:Label ID="lblmsg" runat="server" Text="" class="lblerror"></asp:Label>
                            <div id="mtop" runat="server">
                            <div class="form-group">
                                <asp:DropDownList ID="dropdownbank" CssClass="form-control" runat="server" OnSelectedIndexChanged="dropdownbank_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                                        <small class="text-muted">You can send money to a user by his/her username.</small>
                                </div>
                                                        <div class="form-group">
                                <asp:TextBox ID="txtamount" runat="server" CssClass="form-control" placeholder="Amount in PKR"></asp:TextBox>
                                </div>
                            <div class="form-group">
                                <asp:Button ID="btnwithdraw" runat="server" Text="Withdraw Money" CssClass="btn btn-md btn-indigo" OnClick="btnwithdraw_Click" />
                                </div>
                                </div>
                            
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>
