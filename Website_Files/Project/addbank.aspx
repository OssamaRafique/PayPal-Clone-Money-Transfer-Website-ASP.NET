<%@ Page Title="" Language="C#" MasterPageFile="~/loggedin.Master" AutoEventWireup="true" CodeBehind="addbank.aspx.cs" Inherits="Project.addbank" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
                <div class="col-md-12">
                    <div class="card">
					<div class="card-heading card-default">
                            Add Bank Account
                        </div>
                        <div class="card-block">

                            <asp:Label ID="lblmsg" runat="server" Text="" cssclass="lblerror"></asp:Label>
                            <div id="mtop" runat="server">
                            <div class="form-group">
                                <asp:TextBox ID="txtbankname" runat="server" CssClass="form-control" placeholder="Enter Bank Name"></asp:TextBox>
                                        <small class="text-muted">You can add any pakistani bank account.</small>
                                </div>
                                                        <div class="form-group">
                                <asp:TextBox ID="txtbankaccount" runat="server" CssClass="form-control" placeholder="Account IBAN Number"></asp:TextBox>
                                </div>
                            <div class="form-group">
                                <asp:Button ID="btnsend" runat="server" Text="Add Account" CssClass="btn btn-md btn-indigo" OnClick="btnsend_Click"/>
                                </div>
                                </div>
                            
                        </div>
                    </div>
                </div>
            </div>           
</asp:Content>
