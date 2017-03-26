<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="ModificarGarantia.aspx.cs" Inherits="Back_Office.GUI.Garantia.ModificarGarantia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Gestión de Garantias
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
    Modificar
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Breadcrumps" runat="server">
    <li><a href="#"><i class="fa fa-home"></i> Home</a></li>
    <li><a href="#">Gestión de Garantias</a></li>
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
                  <h3 class="box-title">Datos de la Garantia</h3>
                </div><!-- /.box-header -->
                <!-- form start -->
                <form role="form" name="agregar_producto" id="agregar_producto" method="post" runat="server">
                    <div class="box-body" runat="server">

                         <!--Direccion-->
                        <div class="form-group" runat="server">
                            <label for="IdGarantia">Id de la Garantia</label>
                            <input runat="server" class="form-control" id="IdGar" name="IdGar" disabled="disabled">
                        </div>

                        <!--RIF-->
                        <div class="form-group" runat="server">
                            <label for="InputDescripcion">Descripcion</label> <label for="Requerido" style="color: red;">*</label>
                            <textarea rows="10" cols="100" runat="server" type="text" class="form-control" 
                                pattern="^(\J\-[0-9]{9,13})$"
                                id="InputDescripcion" name="InputDescripcion" 
                                placeholder="" required/>
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
