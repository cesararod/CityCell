﻿<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="ModificarMarca.aspx.cs" Inherits="Back_Office.GUI.Marca.ModificarMarca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Modificar Marca
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Breadcrumps" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="contenidoCentral" runat="server">
    <div id="alert" runat="server">
    </div>
    <div class="row">
        <!-- left column -->
        <div class="col-md-6">
            <!-- general form elements -->
            <div class="box box-primary">
                <div class="box-header with-border">
                    <h3 class="box-title">Marca</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form role="form" runat="server" method="post" name="nueva_categoria" id="nueva_categoria">
                    <div class="box-body" runat="server">
                        
                        <div class="form-group" runat="server">
                            <label for="IdMarca">Id de la Marca</label>
                            <input runat="server" class="form-control" id="IdMarca" name="IdMarca" disabled="disabled">
                        </div>

                        <div class="form-group" runat="server">
                            <label for="labelNombre">Nombre Marca<a style="color:rgb(255, 0, 0);">*</a></label>
                            <input type="text" runat="server" class="form-control"
                                pattern="^[0-9a-zñA-ZÑ ]+$"
                                oninvalid="setCustomValidity('Campo obligatorio, no puede tener símbolos')" oninput="setCustomValidity('')"
                                id="nombreMarca" name="NombreMarca"
                                placeholder="Nombre" maxlength="50" required disabled="disabled">
                        </div> 

                        <div class="form-group" runat="server">
                            <label for="labelActivo">Activo</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:DropDownList id="activoMarca" name="activoMarca" class="form-control"  runat="server">
                                    <asp:ListItem Selected="True" Value="1"> Si </asp:ListItem>
                                    <asp:ListItem Value="0"> No </asp:ListItem>
                            </asp:DropDownList>
                        </div>                                               
                        

                        <div class="box-footer" runat="server">
                            <asp:Button ID="buttonGenerarCategoria" Style="margin-top: 5%" class="btn btn-primary" type="submit" runat="server" Text="Generar"  OnClick="buttonModificarMarca_Click"></asp:Button>
                        </div>

                    </div>
                    <!-- /.box-body -->

                    <div class="box-footer" runat="server">
                    </div>
                </form>
            </div>
            <!-- /.box -->

        </div>
        <!--/.col (left) -->
        <!-- right column -->
        <div class="col-md-6" runat="server">
        </div>
    </div>
</asp:Content>
