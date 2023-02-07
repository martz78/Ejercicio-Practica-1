<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="Ejercicio_Practica_1.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
              <div class="container">
            <h4>
                Registro de Productos
            </h4>        
            <div class="rom">
                <div class="col-6 m-auto">
                    <div class="at-1 card">
                        <div class=" card-header">
                            Informacion del Producto
                        </div>
                        <div class="card-body">
                           <div class="m-3">
                               <div class="form-label">Nombre del Producto</div>
                                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                           </div>
                             <div class="m-3">
                               <div class="form-label">Unidades </div>
                                <asp:TextBox ID="TextBox2" CssClass="form-control"
                                    runat="server"></asp:TextBox>
                           </div> 
                             <div class="m-3">
                               <div class="form-label">Precio</div>
                                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                           </div>
                            </div>
                        <div class="auto-style1">
                            <asp:Button CssClass="btn btn-secondary"  ID="ButtonProcesar" runat="server" Text="Mostrar" OnClick="ButtonProcesar_Click" />
                            <br /> 
                            <br />
                            <asp:Button CssClass="btn btn-secondary"  ID="ButtonBorrar" runat="server" Text="Borrar" OnClick="ButtonBorrar_Click" />
                        </div>
                    </div>
                </div>
            </div>    
                    <div class="rom">
                <div class="col-6 mt-3 m-auto">
                    <div runat="server" class="alert alert-secondary" Id="Mensaje">
                    </div>
                </div>
                 
            </div>
        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
</body> 
</html>
