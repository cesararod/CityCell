<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="AgregarCategoria.aspx.cs" Inherits="Back_Office.GUI.Categoria.AgregarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Agregar Nueva Categoría
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
                    <h3 class="box-title">Nueva Categoria</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form role="form" runat="server" method="post" name="nueva_categoria" id="nueva_categoria">
                    <div class="box-body" runat="server">
                        
                        <div class="form-group" runat="server">
                            <label for="labelNombre">Nombre Categoría<a style="color:rgb(255, 0, 0);">*</a></label>
                            <input type="text" runat="server" class="form-control"
                                pattern="^[0-9a-zñA-ZÑ ]+$"
                                oninvalid="setCustomValidity('Campo obligatorio, no puede tener símbolos')" oninput="setCustomValidity('')"
                                id="nombre" name="Nombre"
                                placeholder="Nombre" maxlength="50" required>
                        </div>

                        <div class="form-group" runat="server">
                            <label for="labelActivo">Activo</label>
                            <input type="checkbox" name="activo" value="activo"> <br>
                        </div>

                        <div class="form-group" runat="server">
                            <label for="labelDestacado">Destacado</label>
                            <input type="checkbox" name="destacado" value="destacado"> <br>
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
