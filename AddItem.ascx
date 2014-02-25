<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddItem.ascx.cs" Inherits="LD2.Auction.AddItem" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>

<div class="dnnForm dnnEditBasicSettings" id="dnnEditBasicSettings">
    <div class="dnnFormItem">
        <dnn:label ID="lblTitle" runat="server" text="Title"/>
    </div>
</div>

<div style="float: left;">
    <asp:LinkButton ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" resourcekey="btnSubmit" CssClass="dnnPrimaryAction" />
    <asp:LinkButton ID="btnCancel" runat="server" OnClick="btnCancel_Click" resourcekey="btnCancel" CssClass="dnnSecondaryAction" />
</div>