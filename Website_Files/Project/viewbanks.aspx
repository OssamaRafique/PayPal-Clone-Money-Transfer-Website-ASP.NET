<%@ Page Title="" Language="C#" MasterPageFile="~/loggedin.Master" AutoEventWireup="true" CodeBehind="viewbanks.aspx.cs" Inherits="Project.viewbanks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
                <div class="col-md-12">
                    <div class="card">
					<div class="card-heading card-default">
                            Your Bank Accounts
                        </div>
                        <div class="card-block">
                                <asp:Label ID="lblmsg" runat="server" Text="" class="lblerror"></asp:Label>
                                <asp:GridView ID="banksview" runat="server" AutoGenerateColumns="false" CssClass="table">
                                    <Columns>
                                        <asp:BoundField DataField="bank_name" HeaderText="Bank Name" />
                                        <asp:BoundField DataField="account_no" HeaderText="Account no" />
                                    </Columns>
                                </asp:GridView>
                            
                        </div>
                    </div>
                </div>
            </div>           
</asp:Content>
