<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Reporte04.aspx.cs" Inherits="Back_Office.GUI.Reportes.Reporte04" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Gestión de Busqueda
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
    
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Breadcrumps" runat="server">
    <li><a href="#"><i class="fa fa-home"></i> Home</a></li>
    <li><a href="#">Reportes</a></li>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="alert" runat="server" style="width:530px">
    </div>
    <div class="row">
            <!-- left column -->
            <div class="col-md-12">
              <!-- general form elements -->
              <div class="box box-primary">
                <div class="box-header with-border">
                  <h3 class="box-title">Datos de la busqueda</h3>
                </div><!-- /.box-header -->
                <!-- form start -->
                <form class="form-inline" role="form" name="agregar_promocion" id="agregar_promocion" method="post" runat="server">
                   
                    <div class="box-body" runat="server">

                         <!--Direccion-->
                        <div class="form-group" runat="server">
                            <label for="labelActivo">Activo</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:DropDownList id="Activo" name="Activo" class="form-control"  runat="server">
                                    <asp:ListItem Selected="True" Value="1"> Si </asp:ListItem>
                                    <asp:ListItem Value="0"> No </asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        
                     </div><!-- /.box-body -->

                    <div class="box-footer" runat="server">
                        
                            <asp:Button ID="buttonGenerarCategoria" Style="margin-top: 5%" class="btn btn-primary" type="submit" runat="server" Text="Buscar"  OnClick="buttonBuscar"></asp:Button>
                    </div>

                    <div class="box-body table-responsive no-padding">
                        
                        <table id="example2" class="table table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Nombre</th>
                                    <th>Cedula</th>
                                    <th>Fecha Ingreso</th>
                                    <th>Correo</th>
                                    <th>Telefono</th>
                                    <th>Celular</th>
                                    <th>Estado</th>
                                </tr>
                            </thead>
                              <asp:Literal runat="server" ID="tabla"></asp:Literal>
                            <tbody>
                            </tbody>
                        </table>

                    </div>
                </form>
              </div><!-- /.box -->
            </div><!--/.col (left) -->
          </div>
</asp:Content>