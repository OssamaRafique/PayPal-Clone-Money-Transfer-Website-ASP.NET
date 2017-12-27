<%@ Page Title="" Language="C#" MasterPageFile="~/loggedin.Master" AutoEventWireup="true" CodeBehind="settings.aspx.cs" Inherits="Project.settings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
                <div class="col-md-12">
                    <div class="card">
					<div class="card-heading card-default">
                            Account Settings
                        </div>
                        <div class="card-block">

                            <asp:Label ID="lblmsg" runat="server" Text="" class="lblerror"></asp:Label>
                            <div id="mtop" runat="server">
                            <div class="form-group">
                                <asp:TextBox ID="txtname" runat="server" CssClass="form-control" placeholder="Enter New Name"></asp:TextBox>
                                </div>
                                                        <div class="form-group">
                                <asp:TextBox ID="txtpassword" runat="server" CssClass="form-control" placeholder="Enter Current Password" TextMode="Password"></asp:TextBox>
                                </div>
                            <div class="form-group">
                                <asp:Button ID="btnsend" runat="server" Text="Save Changes" CssClass="btn btn-md btn-indigo" OnClick="btnsend_Click"/>
                                </div>
                                </div>
                            
                        </div>
                    </div>
                </div>
            </div>         
</asp:Content>
