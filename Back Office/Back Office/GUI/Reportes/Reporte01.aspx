<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Reporte01.aspx.cs" Inherits="Back_Office.GUI.Reportes.Reporte01" %>
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
                            <label for="inputEstado">Estado</label> <label for="Requerido" style="color: red;">*</label>
                            <asp:DropDownList runat="server" class="form-control" id="inputEstado" name="inputEstado">

                                <asp:ListItem Selected="True" Value="1"> Caracas </asp:ListItem>
                                    <asp:ListItem Value="2"> Miranda </asp:ListItem>
                                    <asp:ListItem Value="3"> Vargas </asp:ListItem>
                                    <asp:ListItem Value="4"> Delta Amacuro </asp:ListItem>
                                    <asp:ListItem Value="5"> Merida </asp:ListItem>
                                    <asp:ListItem Value="6"> Trujillo </asp:ListItem>
                                    <asp:ListItem Value="7"> Sucre </asp:ListItem>
                                    <asp:ListItem Value="8"> Amazonas </asp:ListItem>
                                    <asp:ListItem Value="9"> Bolivar </asp:ListItem>
                                    <asp:ListItem Value="10"> Apure </asp:ListItem>
                                    <asp:ListItem Value="11"> Zulia </asp:ListItem>
                                    <asp:ListItem Value="12"> Aragua </asp:ListItem>
                                    <asp:ListItem Value="13"> Falcon </asp:ListItem>
                                    <asp:ListItem Value="14"> Carabobo </asp:ListItem>
                                    <asp:ListItem Value="15"> Anzoategui </asp:ListItem>
                                    <asp:ListItem Value="16"> Portuguesa </asp:ListItem>
                                    <asp:ListItem Value="17"> Lara </asp:ListItem>
                            </asp:DropDownList>
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
                                    <th>Cliente</th>
                                    <th>Sub Total (Bs)</th>
                                    <th>Ciudad</th>
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
