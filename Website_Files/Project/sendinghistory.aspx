<%@ Page Title="" Language="C#" MasterPageFile="~/loggedin.Master" AutoEventWireup="true" CodeBehind="sendinghistory.aspx.cs" Inherits="Project.sendinghistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
                <div class="col-md-12">
                    <div class="card">
					<div class="card-heading card-default">
                            Sending History
                        </div>
                        <div class="card-block">
                                <asp:Label ID="lblmsg" runat="server" Text="" class="lblerror"></asp:Label>
                                <asp:GridView ID="tblsent" runat="server" AutoGenerateColumns="false" CssClass="table">
                                    <Columns>
                                        <asp:BoundField DataField="Receiver_Name" HeaderText="Sent To" />
                                        <asp:BoundField DataField="amount" HeaderText="Amount" />
                                        <asp:BoundField DataField="time" HeaderText="Date and Time" />

                                    </Columns>
                                </asp:GridView>
                            
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>
