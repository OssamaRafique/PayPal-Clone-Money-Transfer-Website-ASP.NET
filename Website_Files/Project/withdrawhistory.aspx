<%@ Page Title="" Language="C#" MasterPageFile="~/loggedin.Master" AutoEventWireup="true" CodeBehind="withdrawhistory.aspx.cs" Inherits="Project.withdrawhistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
                <div class="col-md-12">
                    <div class="card">
					<div class="card-heading card-default">
                            Your Withdrawal History
                        </div>
                        <div class="card-block">
                                <asp:Label ID="lblmsg" runat="server" Text="" class="lblerror"></asp:Label>
                                <asp:GridView ID="tbwithdraw" runat="server" AutoGenerateColumns="false" CssClass="table">
                                    <Columns>
                                        <asp:BoundField DataField="bank_name" HeaderText="Bank Name" />
                                        <asp:BoundField DataField="account_no" HeaderText="Account no" />
                                        <asp:BoundField DataField="amount" HeaderText="Amount (PKR)" />
                                        <asp:BoundField DataField="time" HeaderText="Time" />
                                    </Columns>
                                </asp:GridView>
                            
                        </div>
                    </div>
                </div>
            </div>  
</asp:Content>
