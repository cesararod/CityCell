<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="AgregarMarca.aspx.cs" Inherits="Back_Office.GUI.Marca.AgregarMarca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Agregar Nueva Marca
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
                    <h3 class="box-title">Nueva Marca</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                <form role="form" runat="server" method="post" name="nueva_marca" id="nueva_marca">
                    <div class="box-body" runat="server">
                        
                        <div class="form-group" runat="server">
                            <label for="labelNombre">Nombre Marca<a style="color:rgb(255, 0, 0);">*</a></label>
                            <input type="text" runat="server" class="form-control"
                                pattern="^[0-9a-zñA-ZÑ ]+$"
                                oninvalid="setCustomValidity('Campo obligatorio, no puede tener símbolos')" oninput="setCustomValidity('')"
                                id="nombreMarca" name="NombreMarca"
                                placeholder="Nombre" maxlength="50" required>
                        </div> 

                        <div class="form-group" runat="server">
                            <label for="labelActivo">Activo</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:DropDownList id="activoMarca" name="activoMarca" class="form-control"  runat="server">
                                    <asp:ListItem Selected="True" Value="1"> Si </asp:ListItem>
                                    <asp:ListItem Value="2"> No </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                                                
                        <div class="form-group" runat="server">
                            <label for="labelImagen">Imagen</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:FileUpload id="rutaMarca" runat="server">
                            </asp:FileUpload>
                        </div>

                        <div class="box-footer" runat="server">
                            <asp:Button id="buttonGenerarMarca" Style="margin-top: 5%" class="btn btn-primary" type="submit" runat="server" Text="Generar" OnClientClick="return confirm('¿Seguro que desea generar esta factura?');" OnClick="buttonGenerarMarca_Click"></asp:Button>
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
