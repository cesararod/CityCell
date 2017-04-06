<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Reporte03.aspx.cs" Inherits="Back_Office.GUI.Reportes.Reporte03" %>
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
                            <label for="InputCategoria">Categoria</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:DropDownList runat="server" class="form-control" id="Categoria" name="Categoria"></asp:DropDownList>
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
                        
                     </div><!-- /.box-body -->

                    <div class="box-footer" runat="server">
                        
                            <asp:Button ID="buttonGenerarCategoria" Style="margin-top: 5%" class="btn btn-primary" type="submit" runat="server" Text="Buscar"  OnClick="buttonBuscar"></asp:Button>
                    </div>

                    <div class="box-body table-responsive no-padding">
                        <div style="float:right; padding-top:5px;">
                            <a style="margin-right:10px;">Buscador</a>
                            <input id="searchTerm" type="text" onkeyup="doSearch()"/>
                        </div>
                        <table id="example2" class="table table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th># de pedido</th>
                                    <th>Cliente</th>
                                    <th>Prducto</th>
                                    <th>Total (Bs)</th>
                                    <th>Estatus</th>
                                    <th>Categoria</th>
                                    <th>Fecha</th>
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
