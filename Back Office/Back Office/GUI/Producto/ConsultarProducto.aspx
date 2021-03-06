﻿<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="ConsultarProducto.aspx.cs" Inherits="Back_Office.GUI.Producto.ConsultarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Titulo" runat="server">
    Gestión de Productos
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Subtitulo" runat="server">
   <ul class="">
           
            <li id="" class=""><a href="../Producto/AgregaProducto.aspx"> Crear Producto Nuevo</a></li>
            
          </ul>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Breadcrumps" runat="server">
    
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Main content -->
    <div id="alert" runat="server">
    </div>
    <div class="row" runat="server">
        <div class="col-md-12" runat="server">
            <div class="box box-primary" runat="server">
                <form role="form" runat="server" method="post" name="consulta_marca" id="consulta_marca">
                    <div class="box-header with-border" runat="server">
                        <h3 class="box-title">Consulta de Datos</h3>
                        <div class="box-tools" runat="server">
                            <div class="input-group input-group-sm" style="width: 150px;" runat="server">
                                <!--<input name="table_search" class="form-control pull-right" id="textBuscarId" placeholder="Número Factura" type="text" runat="server">-->

                                <div class="input-group-btn">
                                  <!--  <button type="submit" class="btn btn-default" id="BuscadorId" runat="server" Onclick="busquedaNumero_Click"><i class="fa fa-search" ></i></button>-->
                                    
                                </div>

                            </div>
                        </div>
                    </div>
                    <!-- /.box-header -->
                    <script language="javascript">
                        function doSearch() {
                            var tableReg = document.getElementById('example2');
                            var searchText = document.getElementById('searchTerm').value.toLowerCase();
                            for (var i = 1; i < tableReg.rows.length; i++) {
                                var cellsOfRow = tableReg.rows[i].getElementsByTagName('td');
                                var found = false;
                                for (var j = 0; j < cellsOfRow.length && !found; j++) {
                                    var compareWith = cellsOfRow[j].innerHTML.toLowerCase();
                                    if (searchText.length == 0 || (compareWith.indexOf(searchText) > -1)) {
                                        found = true;
                                    }
                                }
                                if (found) {
                                    tableReg.rows[i].style.display = '';
                                } else {
                                    tableReg.rows[i].style.display = 'none';
                                }
                            }
                        }
                    </script>
                    <div class="box-body table-responsive no-padding">
                        <div style="float:right; padding-top:5px;">
                            <a style="margin-right:10px;">Buscador</a>
                            <input id="searchTerm" type="text" onkeyup="doSearch()"/>
                        </div>
                        <table id="example2" class="table table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th>SKU</th>
                                    <th>Nombre</th>
                                    <th>Modelo</th>
                                    <th>Cantidad</th>
                                    <th>Categoria</th>
                                    <th>Activo</th>
                                    <th style="text-align: center;">Acciones</th>
                                </tr>
                            </thead>
                              <asp:Literal runat="server" ID="tabla"></asp:Literal>
                            <tbody>
                            </tbody>
                        </table>

                    </div>
                    <!-- /.box-body -->
                </form>
            </div>
            <!-- /.box -->  

        </div>
        <!-- /.col -->
    </div>

    <!-- /.row -->

    <script type="text/javascript">
        $(document).ready(function () {
            $('#planillascreadas').DataTable();

            var table = $('#planillascreadas').DataTable();
            var planilla;
            var tr;

            $('#planillascreadas tbody').on('click', 'a', function () {
                if ($(this).parent().hasClass('selected')) {
                    req = $(this).parent().prev().prev().prev().prev().text();
                    tr = $(this).parents('tr');//se guarda la fila seleccionada
                    $(this).parent().removeClass('selected');

                }
                else {
                    req = $(this).parent().prev().prev().prev().prev().text();
                    tr = $(this).parents('tr');//se guarda la fila seleccionada
                    table.$('tr.selected').removeClass('selected');
                    $(this).parent().addClass('selected');
                }
            });

        });
        $('#dimension-switch').bootstrapSwitch('setSizeClass', 'switch-small');
    </script>

    <script src="https://gitcdn.github.io/bootstrap-toggle/2.2.0/js/bootstrap-toggle.min.js"></script>

</asp:Content>

