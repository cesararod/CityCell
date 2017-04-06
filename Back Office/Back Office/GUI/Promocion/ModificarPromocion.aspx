<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="ModificarPromocion.aspx.cs" Inherits="Back_Office.GUI.Promocion.ModificarPromocion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Gestión de Promociones
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
    Registrar
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Breadcrumps" runat="server">
    <li><a href="#"><i class="fa fa-home"></i> Home</a></li>
    <li><a href="#">Gestión de Promociones</a></li>
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
                  <h3 class="box-title">Datos de la Promocion</h3>
                </div><!-- /.box-header -->
                <!-- form start -->
                <form role="form" name="agregar_promocion" id="agregar_promocion" method="post" runat="server">
                    <div class="box-body" runat="server">

                        <div class="form-group" runat="server">
                            <label for="IdPromocion">Id de la Promocion</label>
                            <input runat="server" class="form-control" id="IdPromocion" name="IdPromocion" disabled="disabled">
                        </div>
                                                                         
                        <div class="form-group date">
                        <label for="DateEmployee">Fecha de Inicio</label> <label for="Requerido" style="color: red;">*</label>
                        <div class="form-control input-group date ">
                            <input type="date" class="form-control" placeholder="fecha de inicio" id="fecha_inicio"
                                runat="server" oninput="setCustomValidity('')"
                                required>
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                        </div>
                        </div>

                        <div class="form-group date">
                        <label for="DateEmployee">Fecha de Finalizacion</label> <label for="Requerido" style="color: red;">*</label>
                        <div class="form-control input-group date ">
                            <input type="date" class="form-control" placeholder="fecha de finalizacion" id="fecha_fin"
                                runat="server" oninput="setCustomValidity('')"
                                required>
                            <div class="input-group-addon">
                                <i class="fa fa-calendar"></i>
                            </div>
                        </div>
                        </div>

                        <div class="form-group" runat="server">
                            <label for="InputPrecio">Precio (Bs)</label><label for="Requerido" style="color: red;">*</label> 
                            <input runat="server" type="text" class="form-control" id="InputPrecio" name="InputPrecio" 
                                placeholder="Introduzca el precio del producto" maxlength="10" oninput="setCustomValidity('')" pattern="^[0-9]*$" oninvalid="setCustomValidity('Campo inválido')">
                        </div>
                     </div><!-- /.box-body -->

                    <div class="box-footer" runat="server">
                        
                            <asp:Button ID="buttonGenerarCategoria" Style="margin-top: 5%" class="btn btn-primary" type="submit" runat="server" Text="Generar"  OnClick="buttonGenerar_Click"></asp:Button>
                    </div>
                </form>
              </div><!-- /.box -->
            </div><!--/.col (left) -->
          </div>
</asp:Content>