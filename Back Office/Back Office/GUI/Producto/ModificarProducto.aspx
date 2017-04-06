<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="ModificarProducto.aspx.cs" Inherits="Back_Office.GUI.Producto.ModificarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Gestión de Productos
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
    Modificar
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Breadcrumps" runat="server">
    <li><a href="#"><i class="fa fa-home"></i> Home</a></li>
    <li><a href="#">Gestión de Productos</a></li>
    <li class="active">Modificar</li>
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
                  <h3 class="box-title">Datos del Producto</h3>
                </div><!-- /.box-header -->
                <!-- form start -->
                <form role="form" name="agregar_producto" id="agregar_producto" method="post" runat="server">
                    <div class="box-body" runat="server">

                         <div class="form-group" runat="server">
                            <label for="IdProducto">Id del Producto</label>
                            <input runat="server" class="form-control" id="IdProducto" name="IdProducto" disabled="disabled">
                        </div>

                        <!--Nombre-->
                        <div class="form-group" runat="server">
                            <label for="InputNombre">Nombre</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="InputNombre" name="InputNombre" 
                                placeholder="Introduzca nombre del producto" maxlength="50" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" required oninvalid="setCustomValidity('Campo inválido o vacío')">
                        </div>
                        <!--Acronimo-->
                        <div class="form-group" runat="server">
                            <label for="InputModelo">Modelo</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="InputModelo" name="InputModelo" 
                                placeholder="Introduzca el modelo del producto" maxlength="10" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" oninvalid="setCustomValidity('Campo inválido')">
                        </div>
                        <!--RIF-->
                        <div class="form-group" runat="server">
                            <label for="InputDescripcion">Descripcion</label> <label for="Requerido" style="color: red;">*</label>
                            <textarea rows="10" cols="100" runat="server" type="text" class="form-control" 
                                pattern="^(\J\-[0-9]{9,13})$"
                                id="InputDescripcion" name="InputDescripcion" 
                                placeholder="" required/>
                        </div>

                        <div class="form-group" runat="server">
                            <label for="InputPrecio">Precio</label><label for="Requerido" style="color: red;">*</label> 
                            <input runat="server" type="text" class="form-control" id="InputPrecio" name="InputPrecio" 
                                placeholder="Introduzca el precio del producto" maxlength="10" oninput="setCustomValidity('')" pattern="^[0-9]*$" oninvalid="setCustomValidity('Campo inválido')" required>
                        </div>

                        <div class="form-group" runat="server">
                            <label for="InputCantidad">Cantidad</label><label for="Requerido" style="color: red;">*</label> 
                            <input runat="server" type="text" class="form-control" id="Cantidad" name="Cantidad" 
                                placeholder="Introduzca Cantidad del producto" maxlength="3" oninput="setCustomValidity('')" pattern="^[0-9]*$" oninvalid="setCustomValidity('Campo inválido')" required>
                        </div>
                       
                        <div class="form-group" runat="server">
                            <label for="labelActivo">Activo</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:DropDownList id="Activo" name="Activo" class="form-control"  runat="server">
                                    <asp:ListItem Selected="True" Value="1"> Si </asp:ListItem>
                                    <asp:ListItem Value="0"> No </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                     </div><!-- /.box-body -->

                    <div class="box-footer" runat="server">
                        
                            <asp:Button ID="buttonGenerarCategoria" Style="margin-top: 5%" class="btn btn-primary" type="submit" runat="server" Text="Generar"  OnClick="buttonModificar_Click"></asp:Button>
                    </div>
                </form>
              </div><!-- /.box -->
            </div><!--/.col (left) -->
          </div>
</asp:Content>
