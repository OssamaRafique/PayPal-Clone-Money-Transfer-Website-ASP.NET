<%@ Page Title="" Language="C#" MasterPageFile="~/loggedin.Master" AutoEventWireup="true" CodeBehind="uploadavatar.aspx.cs" Inherits="Project.uploadavatar" %>
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
										<label>Select Image</label>
										<div class="fileinput-new" data-provides="fileinput">
										  <div class="fileinput-preview" data-trigger="fileinput" style="border: none!important;"></div>
											<span class="btn btn-primary  btn-file">
												<span class="fileinput-new">Select</span>
												<span class="fileinput-exists">Change</span>
<asp:FileUpload ID="avimage" runat="server" name="image"/>
											</span>
                                            
											<a href="#" class="btn btn-danger fileinput-exists" data-dismiss="fileinput">Remove</a>
										</div>
									</div>
                            <div class="form-group">
                                <asp:Button ID="btnsave" runat="server" Text="Save Avatar" CssClass="btn btn-md btn-indigo" OnClick="btnsave_Click"  />
                                </div>
                                </div>

                        </div>
                    </div>
                </div>
            </div>     
</asp:Content>
