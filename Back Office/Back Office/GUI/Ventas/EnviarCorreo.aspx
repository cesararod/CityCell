<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="EnviarCorreo.aspx.cs" Inherits="Back_Office.GUI.Ventas.EnviarCorreo" %>
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
                            <label for="InputNombre">Activo</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="Activo" name="Activo" 
                                placeholder="Introduzca nombre" maxlength="50" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" required oninvalid="setCustomValidity('Campo inválido o vacío')" disabled="disabled">
                        </div>

                         <!--Direccion-->
                        <div class="form-group" runat="server">
                            <label for="InputNombre">Mail</label> <label for="Requerido" style="color: red;">*</label>
                            <input runat="server" type="text" class="form-control" id="mail" name="mail" 
                                placeholder="Introduzca nombre" maxlength="50" oninput="setCustomValidity('')" pattern="^[a-zA-Z0-9_.-]*$" required oninvalid="setCustomValidity('Campo inválido o vacío')" disabled="disabled">
                        </div>
                         
                     </div><!-- /.box-body -->
                    
                </form>
              </div><!-- /.box -->
            </div><!--/.col (left) -->
          </div>
</asp:Content>
