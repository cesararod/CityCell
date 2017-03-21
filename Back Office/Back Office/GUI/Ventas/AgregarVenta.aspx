<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="AgregarVenta.aspx.cs" Inherits="Back_Office.GUI.Ventas.AgregarVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Gestión de Ventas
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
    Registrar Manualmente
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Breadcrumps" runat="server">
    <li><a href="#"><i class="fa fa-home"></i> Home</a></li>
    <li><a href="#">Gestión de Ventas</a></li>
    <li class="active">Registrar</li>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="alert" runat="server" style="width:530px">
    </div>
    <div class="row">
            <!-- left column -->
            <div class="col-md-6">
              <!-- general form elements -->
              <div class="box box-primary">
                <div class="box-header with-border">
                  <h3 class="box-title">Datos de la Venta</h3>
                </div><!-- /.box-header -->
                <!-- form start -->
                <form role="form" name="agregar_promocion" id="agregar_promocion" method="post" runat="server">
                    <div class="box-body" runat="server">

                         <!--Direccion-->
                        <div class="form-group" runat="server">
                            <label for="InputProducto">Seleccione el Producto a vender</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:DropDownList runat="server" class="form-control" id="Producto" name="Producto"></asp:DropDownList>
                        </div>

                        <div class="form-group" runat="server">
                            <label for="InputUsuario">Seleccione el Usuario Comprador</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:DropDownList runat="server" class="form-control" id="Usuario" name="Usuario"></asp:DropDownList>
                        </div>
                        
                        <div class="form-group" runat="server">
                            <label for="InputDirFac">Seleccione Direccion de Facturacion</label> 
                            <asp:DropDownList runat="server" class="form-control" id="DirFac" name="DirFac"></asp:DropDownList>
                        </div>
                        
                        <div class="form-group" runat="server">
                            <label for="InputDirEnv">Seleccione Direccion de Envio</label> 
                            <asp:DropDownList runat="server" class="form-control" id="DirEnv" name="DirEnv"></asp:DropDownList>
                        </div>
                        
                        <div class="form-group" runat="server">
                            <label for="InputEmpresaEnvio">Seleccione Empresa de Envio</label> 
                            <asp:DropDownList runat="server" class="form-control" id="EmpresaEnvio" name="EmpresaEnvio"></asp:DropDownList>
                        </div>
                        
                        <div class="form-group" runat="server">
                            <label for="InputEstatus">Estatus de la compra</label> 
                            <asp:DropDownList runat="server" class="form-control" id="Estatus" name="Estatus"></asp:DropDownList>
                        </div>
                        
                     </div><!-- /.box-body -->

                    <div class="box-footer" runat="server">
                        
                            <asp:Button ID="buttonGenerarCategoria" Style="margin-top: 5%" class="btn btn-primary" type="submit" runat="server" Text="Generar" OnClientClick="return confirm('¿Seguro que desea generar esta factura?');" OnClick="buttonGenerar_Click"></asp:Button>
                    </div>
                </form>
              </div><!-- /.box -->
            </div><!--/.col (left) -->
          </div>
</asp:Content>
