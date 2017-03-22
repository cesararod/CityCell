<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="ModificarVenta.aspx.cs" Inherits="Back_Office.GUI.Ventas.ModificarVenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Gestión de Ventas
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
    Modificar
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
                            <label for="InputNombre">Nombre del Cliente</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="nombre" name="nombre" 
                                placeholder="Introduzca nombre" maxlength="50" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" required oninvalid="setCustomValidity('Campo inválido o vacío')" disabled="disabled">
                        </div>

                         <div class="form-group" runat="server">
                            <label for="InputProducto">Producto</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="producto" name="producto" 
                                placeholder="Introduzca nombre" maxlength="50" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" required oninvalid="setCustomValidity('Campo inválido o vacío')" disabled="disabled">
                        </div>
                        
                        <div class="form-group" runat="server">
                            <label for="Inputorden">#  Orden</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="orden" name="orden" 
                                placeholder="Introduzca nombre" maxlength="50" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" required oninvalid="setCustomValidity('Campo inválido o vacío')" disabled="disabled">
                        </div>
                        
                        <div class="form-group" runat="server">
                            <label for="InputEstatus">Estatus de la compra</label> 
                            <asp:DropDownList runat="server" class="form-control" id="estatus" name="estatus">
                                    <asp:ListItem Selected="True" Value="1"> Pagado </asp:ListItem>
                                    <asp:ListItem Value="0"> Enviado </asp:ListItem>
                                    <asp:ListItem Value="2"> Confirmado </asp:ListItem>
                                    <asp:ListItem Value="3"> Fraude </asp:ListItem>
                                    <asp:ListItem Value="4"> Devuelto </asp:ListItem>
                                    <asp:ListItem Value="5"> Pendiente </asp:ListItem>
                                    <asp:ListItem Value="6"> Pendiente Recordado </asp:ListItem>
                                    <asp:ListItem Value="7"> Fallido</asp:ListItem>
                            </asp:DropDownList>
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
