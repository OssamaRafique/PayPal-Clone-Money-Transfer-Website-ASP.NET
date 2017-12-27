<%@ Page Title="" Language="C#" MasterPageFile="~/loggedin.Master" AutoEventWireup="true" CodeBehind="receivinghistory.aspx.cs" Inherits="Project.receivinghistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
                    <div class="card">
					<div class="card-heading card-default">
                            Receiving History
                        </div>
                        <div class="card-block">
                                <asp:Label ID="lblmsg" runat="server" Text="" class="lblerror"></asp:Label>
                                <asp:GridView ID="tblsent" runat="server" AutoGenerateColumns="false" CssClass="table">
                                    <Columns>
                                        <asp:BoundField DataField="Sender_Name" HeaderText="Received From" />
                                        <asp:BoundField DataField="amount" HeaderText="Amount" />
                                        <asp:BoundField DataField="time" HeaderText="Date and Time" />

                                    </Columns>
                                </asp:GridView>
                            
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>
