<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="ModificarUsuario.aspx.cs" Inherits="Back_Office.GUI.Usuario.ModificarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Gestión de Usuarios
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
    Modificar
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Breadcrumps" runat="server">
    <li><a href="#"><i class="fa fa-home"></i> Home</a></li>
    <li><a href="#">Gestión de Usuarios</a></li>
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
                  <h3 class="box-title">Datos del Usuario</h3>
                </div><!-- /.box-header -->
                <!-- form start -->
                <form role="form" name="agregar_usuario" id="agregar_usuario" method="post" runat="server">
                    <div class="box-body" runat="server">

                        <div class="form-group" runat="server">
                            <label for="IdUsuario">Id del Usuario</label>
                            <input runat="server" class="form-control" id="IdUsuario" name="IdUsuario" disabled="disabled">
                        </div>

                         <!--Direccion-->
                        <div class="form-group" runat="server">
                            <label for="InputNombre">Nombre</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="nombre" name="nombre" 
                                placeholder="Introduzca nombre" maxlength="50" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" required oninvalid="setCustomValidity('Campo inválido o vacío')" disabled="disabled">
                        </div>

                        <div class="form-group" runat="server">
                            <label for="InputNombreApellido">Apellido</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="apellido" name="apellido" 
                                placeholder="Introduzca apellido" maxlength="50" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" required oninvalid="setCustomValidity('Campo inválido o vacío')" disabled="disabled">
                        </div>
                        
                        <!--Nombre-->
                        <div class="form-group date">
                            <label for="InputCedula">Cedula</label> <label for="Requerido" style="color: red;">*</label>
                            <div class="form-control input-group date ">
                                <input type="text" class="form-control" placeholder="C.I." id="cedula" runat="server" name="cedula" 
                                     maxlength="50" oninput="setCustomValidity('')" pattern="^[0-9]*$" 
                                    required oninvalid="setCustomValidity('Campo inválido o vacío')" style="width: 500px !important; height: 54px !important;" disabled="disabled">
                                
                            </div>
                        </div>
                        <!--Acronimo-->
                        <div class="form-group" runat="server">
                            <label for="InputTelefono">Teléfono</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" 
                                id="InputTelefono" name="InputTelefono"
                                pattern="^([0-9]{4}\-[0-9]{7})?(\+[0-9]{1,2}\ [0-9]{3}\-[0-9]{7})?$" 
                                placeholder="Introduzca teléfono e.g: 0212-9774183" 
                                maxlength="15" required>
                        </div>

                        <div class="form-group" runat="server">
                            <label for="InputCelular">Celular</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" 
                                id="celular" name="celular"
                                pattern="^([0-9]{4}\-[0-9]{7})?(\+[0-9]{1,2}\ [0-9]{3}\-[0-9]{7})?$" 
                                placeholder="Introduzca Celular e.g: 0412-xxxxxxx" 
                                maxlength="15" required>
                        </div>
                        <!--RIF-->
                        <div class="form-group" runat="server">
                            <label for="InputPass">Password</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="password" class="form-control" 
                                pattern="^(\J\-[0-9]{9,13})$"
                                id="password" name="password" 
                                placeholder="" required/>
                        </div>

                        <div class="form-group ">
                        <label for="EmailPerson">Correo</label> <label for="Requerido" style="color: red;">*</label>
                        <input type="email" runat="server" id="EmailPerson" maxlength="100" class="form-control" 
                            placeholder="Introduzca una direccion email Ej: correo@dominio.com" required>                       
                        </div>
                         
                     </div><!-- /.box-body -->

                    <div class="box-footer" runat="server">
                        
                            <asp:Button ID="buttonGenerarCategoria" Style="margin-top: 5%" class="btn btn-primary" type="submit" runat="server" Text="Generar" OnClientClick="return confirm('¿Seguro que desea generar esta factura?');" OnClick="buttonUsuario_Click"></asp:Button>
                    </div>
                </form>
              </div><!-- /.box -->
            </div><!--/.col (left) -->
          </div>
</asp:Content>
