<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="Back_Office.GUI.Usuario.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Gestión de Usuarios
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
    Registrar
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Breadcrumps" runat="server">
    <li><a href="#"><i class="fa fa-home"></i> Home</a></li>
    <li><a href="#">Gestión de Usuarios</a></li>
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
                  <h3 class="box-title">Datos del Usuario</h3>
                </div><!-- /.box-header -->
                <!-- form start -->
                <form role="form" name="agregar_usuario" id="agregar_usuario" method="post" runat="server">
                    <div class="box-body" runat="server">

                         <!--Direccion-->
                        <div class="form-group" runat="server">
                            <label for="InputNombre">Nombre</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="nombre" name="nombre" 
                                placeholder="Introduzca nombre" maxlength="50" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" required oninvalid="setCustomValidity('Campo inválido o vacío')">
                        </div>

                        <div class="form-group" runat="server">
                            <label for="InputNombreApellido">Apellido</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="apellido" name="apellido" 
                                placeholder="Introduzca apellido" maxlength="50" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" required oninvalid="setCustomValidity('Campo inválido o vacío')">
                        </div>

                        <div class="form-group" runat="server">
                            <label for="labelGenero">Genero</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:DropDownList id="genero" name="genero" class="form-control"  runat="server">
                                    <asp:ListItem Selected="True" Value="1"> Masculino </asp:ListItem>
                                    <asp:ListItem Value="2"> Femenino </asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <!--Nombre-->
                        <div class="form-group date">
                            <label for="InputCedula">Cedula</label> <label for="Requerido" style="color: red;">*</label>
                            <div class="form-control input-group date ">
                                <input type="text" class="form-control" placeholder="C.I." id="cedula" runat="server" name="cedula" 
                                     maxlength="50" oninput="setCustomValidity('')" pattern="^[0-9]*$" 
                                    required oninvalid="setCustomValidity('Campo inválido o vacío')" style="width: 500px !important; height: 54px !important;">
                                <div class="input-group-addon" style="width: 102px !important;">
                                    <asp:DropDownList id="tipodoc" name="tipodoc" class="form-control"  runat="server">
                                        <asp:ListItem Selected="True" Value="1"> V </asp:ListItem>
                                        <asp:ListItem Value="2"> E </asp:ListItem>
                                        <asp:ListItem Value="3"> J </asp:ListItem>
                                    </asp:DropDownList>
                                </div>
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

                        <div class="form-group date">
                        <label for="DateEmployee">Fecha de Nacimiento</label> <label for="Requerido" style="color: red;">*</label>
                        <div class="form-control input-group date ">
                            <input type="date" class="form-control" placeholder="fecha de nacimiento" id="fecha_nacimineto"
                                runat="server" min="1916-01-01" max="2001-01-01" oninput="setCustomValidity('')"
                                required oninvalid="setCustomValidity('Porfavor colocar una fecha entre 1916 y 2001')">
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                        </div>
                        </div>

                        <div class="form-group ">
                        <label for="EmailPerson">Correo</label> <label for="Requerido" style="color: red;">*</label>
                        <input type="email" runat="server" id="EmailPerson" maxlength="25" class="form-control" 
                            placeholder="Introduzca una direccion email Ej: correo@dominio.com" required>                       
                        </div>

                        <div class="form-group" runat="server">
                            <label for="labelRol">Rol</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:DropDownList id="rol" name="rol" class="form-control"  runat="server">
                                    <asp:ListItem Selected="True" Value="1"> Administrador </asp:ListItem>
                                    <asp:ListItem Value="2"> Operador </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                         
                     </div><!-- /.box-body -->

                    <div class="box-footer" runat="server">
                        
                            <asp:Button ID="buttonGenerarCategoria" Style="margin-top: 5%" class="btn btn-primary" type="submit" runat="server" Text="Generar" OnClientClick="return confirm('¿Seguro que desea generar esta factura?');" OnClick="buttonGenerarUsuario_Click"></asp:Button>
                    </div>
                </form>
              </div><!-- /.box -->
            </div><!--/.col (left) -->
          </div>
</asp:Content>
